using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        Graphics draw;

        Form2 exitForm;

        Panel[] allPanels;

        bool[] lockedPanels;

        int[] indexPanels;

        bool xPlays = true;

        WindowsMediaPlayer selectSound;
        #endregion

        #region PANELS MOUSE CLICKING EVENTS
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[0])
            {
                draw = panel1.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel1.Width) / 2 - 45, (panel1.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[0] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel1.Width) / 2 - 45, (panel1.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[0] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[0] = true;
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[1])
            {
                draw = panel2.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel2.Width) / 2 - 45, (panel2.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[1] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel2.Width) / 2 - 45, (panel2.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[1] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[1] = true;
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[2])
            {
                draw = panel3.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel3.Width) / 2 - 45, (panel3.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[2] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel3.Width) / 2 - 45, (panel3.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[2] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[2] = true;
            }
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[3])
            {
                draw = panel4.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel4.Width) / 2 - 45, (panel4.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[3] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel4.Width) / 2 - 45, (panel4.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[3] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[3] = true;
            }
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[4])
            {
                draw = panel5.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel5.Width) / 2 - 45, (panel5.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[4] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel5.Width) / 2 - 45, (panel5.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[4] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[4] = true;
            }
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[5])
            {
                draw = panel6.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel6.Width) / 2 - 45, (panel6.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[5] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel6.Width) / 2 - 45, (panel6.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[5] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[5] = true;
            }
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[6])
            {
                draw = panel7.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel7.Width) / 2 - 45, (panel7.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[6] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel7.Width) / 2 - 45, (panel7.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[6] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[6] = true;
            }
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[7])
            {
                draw = panel8.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel8.Width) / 2 - 45, (panel8.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[7] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel8.Width) / 2 - 45, (panel8.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[7] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[7] = true;
            }
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            if (!lockedPanels[8])
            {
                draw = panel9.CreateGraphics();
                if (xPlays)
                {
                    draw.DrawString("X", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel9.Width) / 2 - 45, (panel9.Height) / 2 - 50);
                    xPlays = false;
                    indexPanels[8] = 1;
                    MakeSound();
                    Update.Start();
                }
                else
                {
                    draw.DrawString("O", new Font("Century Gothic", 60, FontStyle.Bold), Brushes.Black, (panel9.Width) / 2 - 45, (panel9.Height) / 2 - 50);
                    xPlays = true;
                    indexPanels[8] = 0;
                    MakeSound();
                    Update.Start();
                }
                lockedPanels[8] = true;
            }
        }
        #endregion

        //Update game per 100 ms.
        private void Update_Tick(object sender, EventArgs e)
        {
            WhoIsPlaying(xPlays);
            bool isGameOver = false;
            if (indexPanels[0] == indexPanels[1] && indexPanels[1] == indexPanels[2])
            {
                isGameOver = true;
                Shine(panel1, panel2, panel3);
            }
            else if (indexPanels[3] == indexPanels[4] && indexPanels[4] == indexPanels[5])
            {
                isGameOver = true;
                Shine(panel4, panel5, panel6);
            }
            else if (indexPanels[6] == indexPanels[7] && indexPanels[7] == indexPanels[8])
            {
                isGameOver = true;
                Shine(panel7, panel8, panel9);
            }
            else if (indexPanels[0] == indexPanels[3] && indexPanels[3] == indexPanels[6])
            {
                isGameOver = true;
                Shine(panel1, panel4, panel7);
            }
            else if (indexPanels[1] == indexPanels[4] && indexPanels[4] == indexPanels[7])
            {
                isGameOver = true;
                Shine(panel2, panel5, panel8);
            }
            else if (indexPanels[2] == indexPanels[5] && indexPanels[5] == indexPanels[8])
            {
                isGameOver = true;
                Shine(panel3, panel6, panel9);
            }
            else if (indexPanels[2] == indexPanels[4] && indexPanels[4] == indexPanels[6])
            {
                isGameOver = true;
                Shine(panel3, panel5, panel7);
            }
            else if (indexPanels[0] == indexPanels[4] && indexPanels[4] == indexPanels[8])
            {
                isGameOver = true;
                Shine(panel1, panel5, panel9);
            }

            //Checks If Game Is Over
            if (isGameOver)
            {
                exitForm = new Form2(label1.Text);
                Update.Stop();
                Colorized(Color.Green);
                label1.Text = "GAME OVER!";
                exitForm.ShowDialog();
            }
            else if (!isGameOver && IsADraw() == 5)
            {
                label1.Text = "IT'S A DRAW!";
                exitForm = new Form2(label1.Text);
                Update.Stop();
                for (int i = 0; i < allPanels.Length; i++)
                {
                    allPanels[i].BackColor = Color.Crimson;
                }
                Colorized(Color.Crimson);
                exitForm.ShowDialog();
            }
        }

        //Load Screen
        private void LoadScreen(object sender, EventArgs e)
        {
            lockedPanels = new bool[] { false, false, false, false, false, false, false, false, false };
            indexPanels = new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 };
            allPanels = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9 };
            label1.Text = "X IS PLAYING!";
        }

        //Make sound when one of the panels selected
        private void MakeSound()
        {
            selectSound = new WindowsMediaPlayer();
            selectSound.URL = $@"C:\Users\{Environment.UserName}\OneDrive\Desktop\.Net\XOX\Tic-Tac-Toe\Sounds\selectPanel.wav";
            selectSound.controls.play();
        }

        //Determine who's playing
        private void WhoIsPlaying(bool player)
        {
            if (player == true)
            {
                label1.Text = "X IS PLAYING";
            }
            else
            {
                label1.Text = "O IS PLAYING";
            }
        }

        //Check If Its A Draw
        private int IsADraw()
        {
            int sum = 0;
            for (int i = 0; i < indexPanels.Length; i++)
            {
                sum += indexPanels[i];
            }
            return sum;
        }

        //Blink when game is over
        private void Shine(Panel a, Panel b, Panel c)
        {
            Panel[] panels = { a, b, c };
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].BackColor = Color.Green;
            }
        }

        //Change panels colors
        private void Colorized(Color c)
        {
            panel10.BackColor = c;
            panel11.BackColor = c;
            panel12.BackColor = c;
            panel13.BackColor = c;
        }

        //Escape KeyDown Handler
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                exitForm = new Form2("");
                exitForm.ShowDialog();
            }
        }
    }
}
