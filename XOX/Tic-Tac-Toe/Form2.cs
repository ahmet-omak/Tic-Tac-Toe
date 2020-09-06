using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        string winner = "";
        public Form2(string winner)
        {
            InitializeComponent();
            this.winner = winner;
        }

        //Starts A New Game
        private void button1_Click(object sender, EventArgs e) => Application.Restart();

        //Exits The Game
        private void button2_Click(object sender, EventArgs e) => Environment.Exit(1);

        //Prints Who Wins 
        private void Form2_Load(object sender, EventArgs e)
        {
            if (winner=="X IS PLAYING")
            {
                label1.Text = "O Wins!";
            }
            else if (winner=="O IS PLAYING")
            {
                label1.Text = "X Wins!";
            }
            else if(winner=="")
            {
                label1.Visible = false;
            }
            else
            {
                label1.Text = "It's A Draw";
            }
        }

        //If The User Closes Exit Form, Game Form Will Also Be Closed
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (label1.Visible)
            {
                Application.Exit();
            }
        }
    }
}
