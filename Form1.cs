using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace XO_GUT_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int turn = 0;
        private int count = 0;
        private int player1_wins = 0;
        private int player2_wins = 0;

        private void Button_Click(object sender, EventArgs e)
        {
            List<Button> buttonList = new List<Button>() {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
            };

            bool change = false;
            bool done = false;

            foreach (Button button in buttonList)
            {
                if (done)
                {
                    break;
                }

                if (button == sender)
                {
                    done = true;
                    Utilities.Change_Turn(Turn_box, turn, button);
                    change = Utilities.Input(button, turn);
                }
            }

            if (change)
            {
                string winner = Utilities.Check(buttonList);
                if (winner == "X")
                {
                    player1_wins++;
                    Player1_score.Text = Convert.ToString(player1_wins);
                    MessageBox.Show($"Player1 {winner} wins", "Game Over");
                }
                else if (winner == "O")
                {
                    player2_wins++;
                    Player2_score.Text = Convert.ToString(player2_wins);
                    MessageBox.Show($"Player2 {winner} wins", "Game Over");
                }
                else if (count == 9)
                {
                    MessageBox.Show("Tie");

                }
                if (winner == "X" || winner == "O" || count == 9)
                {
                    turn = 1;
                    count = 0;
                    Utilities.Change_Turn(Turn_box, turn, Play_again_button);
                    Utilities.Reset_Tic_Tac_toe(this);
                }
                turn++;
                count++;
            }
        }


        private void Play_again_button_Click(object sender, EventArgs e)
        {
            turn = 1;
            count = 0;
            Utilities.Change_Turn(Turn_box, turn, Play_again_button);
            turn = 0;
            Utilities.Reset_Tic_Tac_toe(this);
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            turn = 1;
            count = 0;
            player1_wins = 0;
            player2_wins = 0;
            Utilities.ResetAllControls(this);
            Player1_score.Text = "0";
            Player2_score.Text = "0";
            Utilities.Change_Turn(Turn_box, turn, Reset_button);
            turn = 0;
        }
    }
}

