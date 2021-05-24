using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonzalez_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_A1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_A2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_A3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_B1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_B2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_B3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_C1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_C2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_C3_Click(object sender, EventArgs e)
        {

        }

        //
        //Once executed, the function checks if one of the following conditions is met
        //

        public void CheckWin_Algo()
        {
            bool MessageWinner = false;

            //
            //Horizontal Patterns
            //

            // A1 = A2 = A3 & A1 != " "
            if ((Btn_A1.Text == Btn_A2.Text) && (Btn_A2.Text == Btn_A3.Text) && (Btn_A1.Text != " "))
            {
                MessageWinner = true;
            }

            // B1 = B2 = B3 & B1 != " "
            else if ((Btn_B1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_B3.Text) && (Btn_B1.Text != " "))
            {
                MessageWinner = true;
            }

            // C1 = C2 = C3 & C1 != " "
            else if ((Btn_C1.Text == Btn_C2.Text) && (Btn_C2.Text == Btn_C3.Text) && (Btn_C1.Text != " "))
            {
                MessageWinner = true;
            }

            //
            //Vertical Patterns
            //

            // A1 = B1 = C1 & A1 != " "
            else if ((Btn_A1.Text == Btn_B1.Text) && (Btn_C1.Text == Btn_C1.Text) && (Btn_B1.Text != " "))
            {
                MessageWinner = true;
            }

            // A2 = B2 = C3 & A2 != " "
            else if ((Btn_A2.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C2.Text) && (Btn_A2.Text != " "))
            {
                MessageWinner = true;
            }

            // A3 = B3 = C3 & A3 != " "
            else if ((Btn_A3.Text == Btn_B3.Text) && (Btn_B3.Text == Btn_C3.Text) && (Btn_A3.Text != " "))
            {
                MessageWinner = true;
            }

            //Diagonal Patterns

            // A1 = B2 = C3 & A1 != " "
            else if ((Btn_A1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C3.Text) && (Btn_A1.Text != " "))
            {
                MessageWinner = true;
            }

            // A3 = B2 = C1 & A3 != " "
            else if ((Btn_A3.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C1.Text) && (Btn_A3.Text != " "))
            {
                MessageWinner = true;
            }
        }

    }
}
