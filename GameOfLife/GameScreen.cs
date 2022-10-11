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
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        Bitmap field;
        //int[,] matrix;
        public List<int[,]> mats;
        int fieldWidth = 750;
        int fieldHight = 750;
        int matrixWidth = 50;
        int matrixHight = 50;
        int quadsX;
        int quadsY;
        point[,] squarePos;
        int matNum;
        int[,] aura;
        bool IsStarted;
        ThreadStart start;
        Thread play;
        double fps;
        bool isOnceSaved;
        bool saveState;
        public string name;
        string FullFileName;
        bool exit;
        int lastRenderedMatNum;

        public Form menuForm;

        struct point
        {
            public int x;
            public int y;
        }

        private void initialisation()
        {
            field = new Bitmap(fieldWidth, fieldHight);
            //mats = new List<int[,]>();
            matNum = mats.Count - 1;
            //matNum = 0;
            IsStarted = false;
            exit = false;
            fps = 1;
            lastRenderedMatNum = 0;
            start = new ThreadStart(Play);
            play = new Thread(start);
            play.Start();
            saveState = false;
            isOnceSaved = false;
            SFD.FileName = name + ".golsv";
            FullFileName = null;

            //aura = new int[matrixWidth, matrixHight];
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

        delegate void stringSender(string text);
        void RenderImg()
        {
            Color white = Color.FromArgb(255, 255, 255);
            Color orange = Color.FromArgb(255, 128, 0);
            for (int X = 0; X < matrixWidth; X++)
                for (int Y = 0; Y < matrixHight; Y++)
                    if (mats[matNum][X, Y] != mats[lastRenderedMatNum][X, Y])
                        if (mats[matNum][X, Y] == 1)
                            for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                                for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                    field.SetPixel(x, y, orange);
                        else if (mats[matNum][X, Y] == 0)
                            for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                                for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                    field.SetPixel(x, y, white);
            Field.Image = field;
            //string fcl_ = "Frames: " + matNum + " / " + (mats.Count() - 1).ToString();
            FCLabelTextChanger("Frames: " + matNum + " / " + (mats.Count() - 1).ToString());
            lastRenderedMatNum = matNum;
            Log();
        }
        void FCLabelTextChanger(string text)
        {
            if (FramesCounterLabel.InvokeRequired)
                Invoke(new stringSender(FCLabelTextChanger), text);
            else
                FramesCounterLabel.Text = text;

        }

        void RenderFrame()
        {
            mats.Add(new int[matrixWidth, matrixHight]);
            //matNum++;
            aura = new int[matrixWidth, matrixHight];
            /*for (int X = 1; X < matrixWidth - 1; X++)
                for (int Y = 1; Y < matrixHight - 1; Y++)
                    if (mats[matNum - 1][X, Y] == 1)
                        for (int x = X; x <= X + 1; x++)
                            for (int y = Y - 1; y <= Y + 1; y++)
                                if (mats[matNum - 1][X, 0] == 1)
                                {
                                    checkQuad(x, y);
                                }*/
            for (int x = 1; x < matrixWidth - 1; x++)
                for (int y = 1; y < matrixHight - 1; y++)
                    if (mats[matNum - 1][x, y] == 1)
                        checkQuad(x, y);
            for (int X = 1; X < matrixWidth - 1; X++)
            {
                if (mats[matNum - 1][X, 0] == 1)
                {
                    checkQuad_(X, 0, "T");
                }
                if (mats[matNum - 1][X, matrixHight - 1] == 1)
                {
                    checkQuad_(X, matrixHight - 1, "B");
                }
            }
            for (int Y = 1; Y < matrixWidth - 1; Y++)
            {
                if (mats[matNum - 1][0, Y] == 1)
                {
                    checkQuad_(0, Y, "L");
                }
                if (mats[matNum - 1][matrixWidth - 1, Y] == 1)
                {
                    checkQuad_(matrixWidth - 1, Y, "R");
                }
            }
            if (mats[matNum - 1][0, 0] == 1)
            {
                checkQuad_(0, 0, "LT");
            }
            if (mats[matNum - 1][0, matrixHight - 1] == 1)
            {
                checkQuad_(0, matrixHight - 1, "LB");
            }
            if (mats[matNum - 1][matrixWidth - 1, 0] == 1)
            {
                checkQuad_(matrixWidth - 1, 0, "RT");
            }
            if (mats[matNum - 1][matrixWidth - 1, matrixHight - 1] == 1)
            {
                checkQuad_(matrixWidth - 1, matrixHight - 1, "RB");
            }
            for (int x = 0; x < matrixWidth; x++)
                for (int y = 0; y < matrixHight; y++)
                    if ((aura[x, y] > 2) && (aura[x, y] < 4))
                        mats[matNum][x, y] = 1;
                    else if ((aura[x, y] < 2) || (aura[x, y] > 3))
                        mats[matNum][x, y] = 0;
                    else
                        mats[matNum][x, y] = mats[matNum - 1][x, y];
            //RenderImg();
        }
        void Log()
        {
            if (matNum != 0)
            {
                int AliveTimer = 0;
                int BornTimer = 0;
                int DiedTimer = 0;
                for (int x = 0; x < matrixWidth; x++)
                    for (int y = 0; y < matrixHight; y++)
                    {
                        if (mats[matNum][x, y] == 1)
                            AliveTimer++;
                        if ((mats[matNum - 1][x, y] == 0) && (mats[matNum][x, y] == 1))
                            BornTimer++;
                        else if ((mats[matNum - 1][x, y] == 1) && (mats[matNum][x, y] == 0))
                            DiedTimer++;
                    }
                WriteLogA(AliveTimer.ToString());
                WriteLogB(BornTimer.ToString());
                WriteLogD(DiedTimer.ToString());
                if (EnableLogCheckbox.CheckState == CheckState.Checked)
                    if (matNum == mats.Count - 1)
                        for (int i = 0; i < matNum; i++)
                            if (mats[i] == mats[matNum])
                                WriteLogL(matNum.ToString() + " = " + i.ToString());
                /*
            {
                for (int x = 0; x < matrixWidth; x++)
                    for (int y = 0; y < matrixHight; y++)
                    {
                        if (mats[i][x, y] == mats[matNum][x, y])
                            timer++;
                    }
                if (timer == 2500)
                    WriteLogL(matNum.ToString() + " = " + i.ToString());
            }*/
            }
        }
        delegate void writeLog(string text);
        void WriteLogA(string text)
        {
            if (AliveQuadsLabel.InvokeRequired)
                Invoke(new stringSender(WriteLogA), text);
            else
                AliveQuadsLabel.Text = "Alive: " + text;
        }
        void WriteLogB(string text)
        {
            if (BornQuadsLabel.InvokeRequired)
                Invoke(new stringSender(WriteLogB), text);
            else
                BornQuadsLabel.Text = "Born: " + text;
        }
        void WriteLogD(string text)
        {
            if (DiedQuadsLabel.InvokeRequired)
                Invoke(new stringSender(WriteLogD), text);
            else
                DiedQuadsLabel.Text = "Died: " + text;
        }
        void WriteLogL(string text)
        {
            if (LogTextbox.InvokeRequired)
                Invoke(new stringSender(WriteLogL), text);
            else
                LogTextbox.Text += text + Environment.NewLine;
        }
        void checkQuad(int x, int y)
        {
            for (int n = x - 1; n <= x + 1; n++)
                for (int m = y - 1; m <= y + 1; m++)
                    if ((n != x) || (m != y))
                        aura[n, m]++;
        }
        void checkQuad_(int x, int y, string pos)
        {
            switch (pos)
            {
                case "T":
                    {
                        for (int n = x - 1; n <= x + 1; n++)
                            for (int m = y; m <= y + 1; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "B":
                    {
                        for (int n = x - 1; n <= x + 1; n++)
                            for (int m = y - 1; m <= y; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "L":
                    {
                        for (int n = x; n <= x + 1; n++)
                            for (int m = y - 1; m <= y + 1; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "R":
                    {
                        for (int n = x - 1; n <= x; n++)
                            for (int m = y - 1; m <= y + 1; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "LT":
                    {
                        for (int n = x; n <= x + 1; n++)
                            for (int m = y; m <= y + 1; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "LB":
                    {
                        for (int n = x; n <= x + 1; n++)
                            for (int m = y - 1; m <= y; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "RT":
                    {
                        for (int n = x - 1; n <= x; n++)
                            for (int m = y; m <= y + 1; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
                case "RB":
                    {
                        for (int n = x - 1; n <= x; n++)
                            for (int m = y - 1; m <= y; m++)
                                if ((n != x) || (m != y))
                                    aura[n, m]++;
                    }
                    break;
            }
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
                    if (mats[0][X, Y] == 1)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, orange);
                    else if (mats[0][X, Y] == 0)
                        for (int x = squarePos[X, Y].x; x < squarePos[X, Y].x + quadsX - 2; x++)
                            for (int y = squarePos[X, Y].y; y < squarePos[X, Y].y + quadsY - 2; y++)
                                field.SetPixel(x, y, white);
            Field.Image = field;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            /*initialisation();
            mats.Add(new int[matrixWidth, matrixHight]);
            PreLoadRender();
            //matNum++;
            mats.Add(new int[matrixWidth, matrixHight]);
            matNum++;
            mats[matNum][11, 10] = 1;
            mats[matNum][12, 10] = 1;
            mats[matNum][13, 10] = 1;

            mats[matNum][10, 11] = 1;
            mats[matNum][10, 12] = 1;
            mats[matNum][10, 13] = 1;

            mats[matNum][14, 11] = 1;
            mats[matNum][14, 12] = 1;
            mats[matNum][14, 13] = 1;

            mats[matNum][11, 14] = 1;
            mats[matNum][12, 14] = 1;
            mats[matNum][13, 14] = 1;
            RenderImg();*/
        }
        public void PLR()
        {
            initialisation();
            PreLoadRender();
            if (mats.Count > 1)
                RenderImg();
        }

        void Play()
        {
            while (exit == false)
                while (IsStarted == true)
                {
                    if (mats.Count - 2 < matNum)
                    {
                        matNum++;
                        RenderFrame();
                        RenderImg();
                        //matNum++;
                        Thread.Sleep(Convert.ToInt32(1000 / fps));
                    }
                    else
                    {
                        matNum++;
                        RenderImg();
                        //matNum++;
                        Thread.Sleep(Convert.ToInt32(1000 / fps));
                    }

                }
        }

        private void StartStopBut_Click(object sender, EventArgs e)
        {
            if (IsStarted == false)
            {
                IsStarted = true;
                StartStopBut.Text = "Stop";
            }
            else
            {
                IsStarted = false;
                StartStopBut.Text = "Start";
            }
        }

        private void FPSTrackBar_Scroll(object sender, EventArgs e)
        {
            FPSTextBar.Text = FPSTrackBar.Value.ToString();
        }

        private void SetFpsBut_Click(object sender, EventArgs e)
        {
            if (FPSTextBar.Text != String.Empty)
                if (double.Parse(FPSTextBar.Text) > 0)
                    fps = double.Parse(FPSTextBar.Text);
                else
                    MessageBox.Show("Invalid fps value!");
            else
                MessageBox.Show("Invalid fps value!");
        }

        private void GoToFrameBut_Click(object sender, EventArgs e)
        {
            if (GoToFrameTextBox.Text != String.Empty)
            {
                int frame = int.Parse(GoToFrameTextBox.Text);
                if (int.Parse(GoToFrameTextBox.Text) >= 0)
                {
                    if (frame > matNum)
                    {
                        for (int i = matNum + 1; i <= frame; i++)
                        {
                            matNum++;
                            RenderFrame();
                        }
                        RenderImg();
                    }
                    else
                    {
                        matNum = frame;
                        RenderImg();
                    }
                }
                else
                    MessageBox.Show("Invalid frame value!");
            }
            else
                MessageBox.Show("Invalid frame value!");
        }

        private void PreviousFrameBut_Click(object sender, EventArgs e)
        {
            if (matNum != 0)
            {
                matNum--;
                RenderImg();
            }
            else
                MessageBox.Show("It's 0 matrix!");
        }

        private void NextFrameBut_Click(object sender, EventArgs e)
        {
            if (mats.Count - 2 < matNum)
            {
                matNum++;
                RenderFrame();
            }
            else
                matNum++;
            RenderImg();
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
            for (int i = 0; i < mats.Count; i++)
            {
                for (int x = 0; x < matrixWidth; x++)
                    for (int y = 0; y < matrixHight; y++)
                        num += mats[i][x, y].ToString();
                num += Environment.NewLine;
            }
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
