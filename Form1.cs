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


        //Instatiation of variables to be used in the turn-based code
        bool PlayerTurn = false;
        byte PlayerTurn_Count = 0;

        private void Btn_A1_Click(object sender, EventArgs e)
        {

            try
            {
               
                // If PlayerTurn = true, it will be X's turn, otherwise it will be O's
                if (PlayerTurn == true)
                {
                    Btn_A1.Text = "X";
                }
                else
                {
                    Btn_A1.Text = "O";
                }

                //Invert PlayerTurn value from true -> false, vice versa,
                //makes alternate turns possible
                PlayerTurn = !PlayerTurn;

                //PlayerTurn_Count increments, so as to count moves until a maximum is reached
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_A2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_A2.Text = "X";
                }
                else
                {
                    Btn_A2.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }

        }

        private void Btn_A3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_A3.Text = "X";
                }
                else
                {
                    Btn_A3.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_B1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_B1.Text = "X";
                }
                else
                {
                    Btn_B1.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_B2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_B2.Text = "X";
                }
                else
                {
                    Btn_B2.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_B3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_B3.Text = "X";
                }
                else
                {
                    Btn_B3.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_C1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_C1.Text = "X";
                }
                else
                {
                    Btn_C1.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_C2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_C2.Text = "X";
                }
                else
                {
                    Btn_C2.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
        }

        private void Btn_C3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayerTurn == true)
                {
                    Btn_C3.Text = "X";
                }
                else
                {
                    Btn_C3.Text = "O";
                }
                PlayerTurn = !PlayerTurn;
                PlayerTurn_Count++;
                CheckWin_Algo();
            }
            catch
            {

            }
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
            if ((Btn_A1.Text == Btn_A2.Text) && (Btn_A2.Text == Btn_A3.Text) && (Btn_A1.Text !=""))
            {
                MessageWinner = true;

            }

            // B1 = B2 = B3 & B1 != " "
            else if ((Btn_B1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_B3.Text) && (Btn_B1.Text !=""))
            {
                MessageWinner = true;

            }

            // C1 = C2 = C3 & C1 != " "
            else if ((Btn_C1.Text == Btn_C2.Text) && (Btn_C2.Text == Btn_C3.Text) && (Btn_C1.Text !=""))
            {
                MessageWinner = true;

            }

            //
            //Vertical Patterns
            //

            // A1 = B1 = C1 & A1 != " "
            else if ((Btn_A1.Text == Btn_B1.Text) && (Btn_B1.Text == Btn_C1.Text) && (Btn_C1.Text !=""))
            {
                MessageWinner = true;

            }

            // A2 = B2 = C3 & A2 != " "
            else if ((Btn_A2.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C2.Text) && (Btn_A2.Text !=""))
            {
             MessageWinner = true;

            }

            // A3 = B3 = C3 & A3 != " "
            else if ((Btn_A3.Text == Btn_B3.Text) && (Btn_B3.Text == Btn_C3.Text) && (Btn_A3.Text !=""))
            {
                MessageWinner = true;

            }

            //Diagonal Patterns

            // A1 = B2 = C3 & A1 != " "
            else if ((Btn_A1.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C3.Text) && (Btn_A1.Text !=""))
            {
                MessageWinner = true;

            }

            // A3 = B2 = C1 & A3 != " "
            else if ((Btn_A3.Text == Btn_B2.Text) && (Btn_B2.Text == Btn_C1.Text) && (Btn_A3.Text !=""))
            {
                MessageWinner = true;

            }

            if (MessageWinner == true)
            {
                string WinMsg = " ";
                if (PlayerTurn == true)
                {
                    WinMsg = "O";
                }
                else
                {
                    WinMsg = "X";
                }

                MessageBox.Show("The winner is" + " " + WinMsg);

            }
            else if (PlayerTurn_Count == 9)
            {
                MessageBox.Show("No winners this time :( ");
            }
        }

    }
}
