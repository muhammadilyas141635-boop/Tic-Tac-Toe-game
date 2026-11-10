using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe._12345
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enabled_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }

        void score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.Pink;
                btnTic4.BackColor = Color.Pink;
                btnTic7.BackColor = Color.Pink;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.Crimson;
                btnTic5.BackColor = Color.Crimson;
                btnTic7.BackColor = Color.Crimson;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.CadetBlue;
                btnTic5.BackColor = Color.CadetBlue;
                btnTic8.BackColor = Color.CadetBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.Violet;
                btnTic6.BackColor = Color.Violet;
                btnTic9.BackColor = Color.Violet;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.DarkSlateBlue;
                btnTic5.BackColor = Color.DarkSlateBlue;
                btnTic6.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.DarkSlateBlue;
                btnTic5.BackColor = Color.DarkSlateBlue;
                btnTic6.BackColor = Color.DarkSlateBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.Azure;
                btnTic8.BackColor = Color.Azure;
                btnTic9.BackColor = Color.Azure;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            //===============================================================================================
            if (btnTic1.Text == "0" && btnTic2.Text == "0" && btnTic3.Text == "0")
            {
                btnTic1.BackColor = Color.AliceBlue;
                btnTic2.BackColor = Color.AliceBlue;
                btnTic3.BackColor = Color.AliceBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic1.Text == "0" && btnTic4.Text == "0" && btnTic7.Text == "0")
            {
                btnTic1.BackColor = Color.LemonChiffon;
                btnTic4.BackColor = Color.LemonChiffon;
                btnTic7.BackColor = Color.LemonChiffon;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic1.Text == "0" && btnTic5.Text == "0" && btnTic9.Text == "0")
            {
                btnTic1.BackColor = Color.BlueViolet;
                btnTic5.BackColor = Color.BlueViolet;
                btnTic9.BackColor = Color.BlueViolet;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic3.Text == "0" && btnTic5.Text == "0" && btnTic7.Text == "0")
            {
                btnTic3.BackColor = Color.NavajoWhite;
                btnTic5.BackColor = Color.NavajoWhite;
                btnTic7.BackColor = Color.NavajoWhite;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic2.Text == "0" && btnTic5.Text == "0" && btnTic8.Text == "0")
            {
                btnTic2.BackColor = Color.SandyBrown;
                btnTic5.BackColor = Color.SandyBrown;
                btnTic8.BackColor = Color.SandyBrown;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic3.Text == "0" && btnTic6.Text == "0" && btnTic9.Text == "0")
            {
                btnTic3.BackColor = Color.SeaGreen;
                btnTic6.BackColor = Color.SeaGreen;
                btnTic9.BackColor = Color.SeaGreen;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic4.Text == "0" && btnTic5.Text == "0" && btnTic6.Text == "0")
            {
                btnTic4.BackColor = Color.Azure;
                btnTic5.BackColor = Color.Azure;
                btnTic6.BackColor = Color.Azure;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
            if (btnTic7.Text == "0" && btnTic8.Text == "0" && btnTic9.Text == "0")
            {
                btnTic7.BackColor = Color.DarkBlue;
                btnTic8.BackColor = Color.DarkBlue;
                btnTic9.BackColor = Color.DarkBlue;
                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int.TryParse(lblPlayerX.Text, out plusone);
                lblPlayerX.Text = (plusone + 1).ToString();
                Enabled_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic2.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic2.Text = "O";
                    checker = false;
                }
                score();
                btnTic2.Enabled = false;
            }
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic3.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic3.Text = "O";
                    checker = false;
                }
                score();
                btnTic3.Enabled = false;
            }
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic4.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic4.Text = "O";
                    checker = false;
                }
                score();
                btnTic4.Enabled = false;
            }
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic5.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic5.Text = "O";
                    checker = false;
                }
                score();
                btnTic5.Enabled = false;
            }
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic6.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic6.Text = "O";
                    checker = false;
                }
                score();
                btnTic6.Enabled = false;
            }
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic7.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic7.Text = "O";
                    checker = false;
                }
                score();
                btnTic7.Enabled = false;
            }
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic8.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic8.Text = "O";
                    checker = false;
                }
                score();
                btnTic8.Enabled = false;
            }
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            {
                if (checker == false)
                {
                    btnTic9.Text = "X";
                    checker = true;
                }
                else
                {
                    btnTic9.Text = "O";
                    checker = false;
                }
                score();
                btnTic9.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lblPlayerX.Text = "0";
                lblPlayerX.Text = "0";

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNewGame.Enabled = true;

                btnTic1.BackColor = Color.WhiteSmoke;
                btnTic2.BackColor = Color.WhiteSmoke;
                btnTic3.BackColor = Color.WhiteSmoke;
                btnTic4.BackColor = Color.WhiteSmoke;
                btnTic5.BackColor = Color.WhiteSmoke;
                btnTic6.BackColor = Color.WhiteSmoke;
                btnTic7.BackColor = Color.WhiteSmoke;
                btnTic8.BackColor = Color.WhiteSmoke;
                btnTic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}