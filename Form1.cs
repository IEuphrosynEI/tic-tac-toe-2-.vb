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

namespace tictactoe
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool turn = true;
        int count_of_turn = 0;
        public Form1()
        {
            InitializeComponent();
            player.URL = "Let the Living Beware.mp3";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;

            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
        }

        private void ttt(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            count_of_turn++;

            Winner();
        }

        private void Winner()
        {
            bool winner = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                winner = true;
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                winner = true;
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                winner = true;
            if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                winner = true;
            if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                winner = true;
            if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                winner = true;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                winner = true;

            if (winner)
            {

                String champ = "";
                if (turn)
                    champ = "O";
                else
                    champ = "X";

                MessageBox.Show(champ + " is a Champ!", "Gratula!");
            }
            else
            {
                if (count_of_turn == 9)
                    MessageBox.Show("Draw!", "Awwww!");
            }
        }
    }
}

