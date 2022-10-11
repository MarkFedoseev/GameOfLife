using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GameOfLife
{
    public partial class NewGameSettings : Form
    {
        public NewGameSettings()
        {
            InitializeComponent();
        }

        Bitmap field;
        int[,] matrix;
        int fieldWidth = 750;
        int fieldHight = 750;
        int matrixWidth = 50;
        int matrixHight = 50;
        int quadsX;
        int quadsY;
        point[,] squarePos;
        Thread draw;
        ThreadStart start;
        bool IsMouseDown;
        short mouseButtonPressed;
        int brushSize;
        bool saveState;
        bool isOnceSaved;
        string FullFileName;
        bool exit;

        public Form menuForm;

        struct point
        {
            public int x;
            public int y;
        }

        private void initialisation()
        {
            IsMouseDown = false;
            mouseButtonPressed = 0;
            brushSize = 0;
            saveState = false;
            FullFileName = null;
            SFD.FileName = ".golsv";
            exit = false;
            start = new ThreadStart(Draw);
            draw = new Thread(start);
            draw.Start();
            field = new Bitmap(fieldWidth, fieldHight);
            matrix = new int[matrixWidth, matrixHight];
            quadsX = fieldWidth / matrixWidth;
            quadsY = fieldHight / matrixHight;
            squarePos = new point[matrixWidth, matrixHight];
            for (int x = 0; x < matrixWidth; x++)
                for (int y = 0; y < matrixHight; y++)
                {
                    squarePos[x, y].x = x * quadsX + 1;
                    squarePos[x, y].y = y * quadsY + 1;
                }
        }

        void RenderImg(int n, int m, int size)
        {
            Color white = Color.FromArgb(255, 255, 255);
            Color orange = Color.FromArgb(255, 128, 0);
            /*for (int X = 0; X < matrixWidth; X++)
                for (int Y = 0; Y < matrixHight; Y++)
                    //if (matrix[X, Y] != mats[matNum - 1][X, Y])
                    if (matrix[X, Y] == 1)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, orange);
                    else if (matrix[X, Y] == 0)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, white);*/
            for (int X = n - size; X <= n + size; X++)
                for (int Y = m - size; Y <= m + size; Y++)
                    if ((X < matrixWidth) && (X >= 0) && (Y < matrixHight) && (Y >= 0))
                        if (matrix[X, Y] == 1)
                            for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                                for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                    field.SetPixel(x, y, orange);
                        else if (matrix[X, Y] == 0)
                            for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                                for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                    field.SetPixel(x, y, white);
            Field.Image = field;
        }

        void PreLoadRender()
        {
            Color black = Color.FromArgb(0, 0, 0);
            Color white = Color.FromArgb(255, 255, 255);
            Color orange = Color.FromArgb(255, 128, 0);
            for (int x = 0; x < matrixWidth; x++)
                for (int y = 0; y < matrixHight; y++)
                {
                    for (int i = squarePos[x, y].x - 1; i < squarePos[x, y].x - 1 + 15; i++)
                    {
                        field.SetPixel(i, squarePos[x, y].y - 1, black);
                        field.SetPixel(i, squarePos[x, y].y - 1 + 14, black);
                    }
                    for (int i = squarePos[x, y].y - 1; i < squarePos[x, y].y - 1 + 15; i++)
                    {
                        field.SetPixel(squarePos[x, y].x - 1, i, black);
                        field.SetPixel(squarePos[x, y].x - 1 + 14, i, black);
                    }
                }
            for (int X = 0; X < matrixWidth; X++)
                for (int Y = 0; Y < matrixHight; Y++)
                    if (matrix[X, Y] == 1)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, orange);
                    else if (matrix[X, Y] == 0)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, white);
            Field.Image = field;
        }

        private void NewGameSettings_Load(object sender, EventArgs e)
        {
            initialisation();
            PreLoadRender();
        }
        private void Field_MouseDown(object sender, MouseEventArgs e)
        {
            if (RB1x1.Checked == true)
                brushSize = 0;
            else if (RB3x3.Checked == true)
                brushSize = 1;
            else if (RB5x5.Checked == true)
                brushSize = 2;
            if (e.Button == MouseButtons.Left)
                mouseButtonPressed = 1;
            if (e.Button == MouseButtons.Right)
                mouseButtonPressed = 2;
            IsMouseDown = true;
        }

        private void Field_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void Field_MouseLeave(object sender, EventArgs e)
        {
            IsMouseDown = false;
        }
        void Draw()
        {
            point lastQuad = new point();
            point ne = new point();
            lastQuad = ne;
            ne.x = matrixWidth;
            ne.y = matrixHight;
            Point mouseCursor;
            int x;
            int y;
            //int ibLocationX = GetIBLocation().X;
            //int ibLocationY = GetIBLocation().Y;
            while (exit == false)
            {
                if (IsMouseDown == true)
                {
                    mouseCursor = GetPoint();
                    //MessageBox.Show(ibLocationX.ToString());
                    x = mouseCursor.X - 13;
                    y = mouseCursor.Y - 13;
                    for (int X = 0; X < matrixWidth; X++)
                        for (int Y = 0; Y < matrixHight; Y++)
                            if ((x > squarePos[X, Y].x) && (x < squarePos[X, Y].x + quadsX - 2) && (y > squarePos[X, Y].y) && (y < squarePos[X, Y].y + quadsX - 2))
                                if ((X != lastQuad.x) || (Y != lastQuad.y))
                                {
                                    if (mouseButtonPressed == 1)
                                    {
                                        for (int n = X - brushSize; n <= X + brushSize; n++)
                                            for (int m = Y - brushSize; m <= Y + brushSize; m++)
                                                if ((n < matrixWidth) && (n >= 0) && (m < matrixHight) && (m >= 0))
                                                    matrix[n, m] = 1;
                                        RenderImg(X, Y, brushSize);
                                    }
                                    else if (mouseButtonPressed == 2)
                                    {
                                        for (int n = X - brushSize; n <= X + brushSize; n++)
                                            for (int m = Y - brushSize; m <= Y + brushSize; m++)
                                                if ((n < matrixWidth) && (n >= 0) && (m < matrixHight) && (m >= 0))
                                                    matrix[n, m] = 0;
                                        RenderImg(X, Y, brushSize);
                                    }
                                    lastQuad.x = X;
                                    lastQuad.y = Y;
                                }
                }
                else
                {
                    lastQuad = ne;
                    mouseButtonPressed = 0;
                }
                Thread.Sleep(10);
            }
        }
        delegate Point getPoint();
        //delegate Point getIBLocation();
        delegate void stringSender(string text);
        void LabelTextChanger(string text)
        {
            if (label1.InvokeRequired)
                Invoke(new stringSender(LabelTextChanger), text);
            else
                label1.Text = text;
        }
        Point GetPoint()
        {
            if (Field.InvokeRequired)
                return (Point)Invoke(new getPoint(GetPoint));
            else
                return PointToClient(Cursor.Position);
        }

        private void LoadBut_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string[] strMats = File.ReadAllLines(OFD.FileName);
                if (strMats[0] != null)
                    for (int x = 0; x < 50; x++)
                        for (int y = 0; y < 50; y++)
                            matrix[x, y] = int.Parse(strMats[strMats.Length - 1][x * 50 + y].ToString());
                RenderImg(25, 25, 25);
                isOnceSaved = true;
                FullFileName = OFD.FileName;
            }
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (isOnceSaved == false)
                SaveFileAs();
            else
            {
                File.WriteAllText(FullFileName, ConstructSaveFile());
                isOnceSaved = true;
            }
            saveState = true;
        }

        private void SaveAsBut_Click(object sender, EventArgs e)
        {
            SaveFileAs();
            saveState = true;
            isOnceSaved = true;
        }
        void SaveFileAs()
        {
            string filename = null;
            ConstructSaveFile();
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                filename = SFD.FileName;
                File.WriteAllText(filename, ConstructSaveFile());
            }
            FullFileName = filename;
        }
        string ConstructSaveFile()
        {
            string num = null;
            for (int x = 0; x < matrixWidth; x++)
                for (int y = 0; y < matrixHight; y++)
                    num += matrix[x, y].ToString();
            return num;
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            if (saveState == false)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to close the window?" + Environment.NewLine + "All unsaved information will be lost", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    exit = true;
                    menuForm.Show();
                    Close();
                }
            }
            else
            {
                exit = true;
                menuForm.Show();
                Close();
            }
        }
    }
}
