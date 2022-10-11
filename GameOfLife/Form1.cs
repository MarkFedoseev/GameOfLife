using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameOfLife
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void NewGameBut_Click(object sender, EventArgs e)
        {
            NewGameSettings ngs = new NewGameSettings();
            ngs.menuForm = this;
            Hide();
            ngs.Show();
        }

        private void LoadGameBut_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                List<int[,]> mats = new List<int[,]>();
                string[] strMats = File.ReadAllLines(OFD.FileName);
                if (strMats[0] != null)
                {
                    for (int i = 0; i < strMats.Length; i++)
                    {
                        mats.Add(new int[50, 50]);
                        for (int x = 0; x < 50; x++)
                            for (int y = 0; y < 50; y++)
                                mats[i][x, y] = int.Parse(strMats[i][x * 50 + y].ToString());
                    }
                    GameScreen gs = new GameScreen();
                    gs.mats = mats;
                    gs.menuForm = this;
                    gs.PLR();
                    Hide();
                    gs.Show();
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("YES button: the story end's, you wake up in your bed and believe what ever you want" + Environment.NewLine + 
                "NO button: you stay in wonderland and i'll show how deep the rabbit hole goes", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
