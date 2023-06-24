using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Utilities
    {

        /// <summary>
        /// resets all the controls provided in the form
        /// </summary>
        /// <param name="form"></param>
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
                if (control is Button)
                {
                    Button button = (Button)control;
                    if (button.Text == "Reset" || button.Text == "Play again")
                    {
                        continue;
                    }
                    button.Text = null;
                    Chang_To_Defult_Color(button);
                }
                
            }
        }

        /// <summary>
        /// resets all the buttons of the board to its original state
        /// </summary>
        /// <param name="form"></param>
        public static void Reset_Tic_Tac_toe(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button && control.Name != "Reset_button" && control.Name != "Play_again_button")
                {
                    control.Text = null;
                    Button button = (Button)control;
                    Chang_To_Defult_Color(button);
                }
            }
        }

        /// <summary>
        ///  modifing the button provided for each player turn
        /// </summary>
        /// <param name="button"> the button that the player clicks it</param>
        /// <param name="turn"> the turn of the player if even -> x else -> o</param>
        /// <returns></returns>
        public static bool Input(Button button, int turn)
        {
            if (button.Text == "" || button.Text == null)
            {
                if (turn % 2 == 1)
                {
                    button.Text = "O";
                }
                else {
                    button.Text = "X";
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// returns a string that is the winner
        /// checking for the winner by checking every column row and diagonal
        /// </summary>
        /// <param name="board"> the state of the board</param>
        /// <returns></returns>
        public static string Check(List<Button> buttonList)
        {
            Button[,] board = Get_Board(buttonList);

            //check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Text == board[i, 1].Text && board[i, 1].Text == board[i, 2].Text && (board[i, 0].Text != ""))
                {
                    Change_Color(board[i, 0]);
                    Change_Color(board[i, 1]);
                    Change_Color(board[i, 2]);
                    return board[i, 0].Text;
                }
            }

            //check columns 
            for (int j = 0; j < 3; j++) {
                if (board[0, j].Text == board[1, j].Text && board[1, j].Text == board[2, j].Text && (board[0, j].Text != ""))
                {
                    Change_Color(board[0, j]);
                    Change_Color(board[1, j]);
                    Change_Color(board[2, j]);
                    return board[0, j].Text;
                }
            }

            //check diagonals
            if (board[0, 0].Text == board[1, 1].Text && board[1, 1].Text == board[2, 2].Text && board[0, 0].Text != "")
            {
                Change_Color(board[0, 0]);
                Change_Color(board[1, 1]);
                Change_Color(board[2, 2]);
                return board[0, 0].Text;
            }
            else if (board[2, 0].Text == board[1, 1].Text && board[1, 1].Text == board[0, 2].Text && board[2, 0].Text != "")
            {
                Change_Color(board[2, 0]);
                Change_Color(board[1, 1]);
                Change_Color(board[0, 2]);
                return board[2, 0].Text;
            }
            else
            {
                return "";
            }

        }


        /// <summary>
        /// changing the players turn by changing the text of the textbox provided
        /// </summary>
        /// <param name="textbox"> the text box provided to change turn </param>
        /// <param name="turn"> if the int is even -> player1 else -> player2 </param>
        /// <param name="button">the button that has been pressed so the method will check if there is x or o so there will be no overwrite</param>
        public static void Change_Turn(TextBox textbox, int turn, Button button)
        {
            if (button.Text != "O" && button.Text != "X")
            {
                if (turn % 2 == 0)
                {
                    textbox.Text = "Player Two (O)";
                }
                else
                {
                    textbox.Text = "Player One (X)";
                }
            }
        }


        /// <summary>
        /// returns the board buttons state
        /// </summary>
        /// <param name="buttons"> the list provided </param>
        /// <returns></returns>
        public static Button[,] Get_Board(List<Button> buttons)
        {
            Button[,] board = new Button[3, 3] {
               { buttons[0], buttons[1], buttons[2] },
               { buttons[3], buttons[4], buttons[5] },
               { buttons[6], buttons[7], buttons[8] },
            };
            return board;
        }


        /// <summary>
        /// changes the button color to green and the font to white when there is a winner
        /// </summary>
        /// <param name="button"> the button that meant to change its color </param>
        private static void Change_Color(Button button)
        {
            // Change the button's background color to red.
            button.BackColor = Color.Green;

            // Change the button's text color to white.
            button.ForeColor = Color.White;
        }

        /// <summary>
        /// restors the button color to white and the font to black when resets
        /// </summary>
        /// <param name="button"> the button that meant to change its color </param>
        private static void Chang_To_Defult_Color(Button button)
        {
            // Change the button's background color to red.
            button.BackColor = Color.White;

            // Change the button's text color to white.
            button.ForeColor = Color.Black;
        }
    }
}
