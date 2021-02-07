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

namespace BuildWordsProject_OmerBenYossef_ItayShachar
{
    public partial class Form_Letters : Form
    {
        public Form_Letters()
        {
            InitializeComponent();

            playerTurnLabel();
        }

        private string[] lettersPlayer1 = new string[5];
        private string[] lettersPlayer2 = new string[5];

        private int counterPlayer1 = 0;
        private int counterPlayer2 = 0;

        private bool m_IsFirstPlayer = true;

        private int leftToChoosePlayer1 = 5;
        private int leftToChoosePlayer2 = 5;

        private double timeCounter = 60.00; // בהגשה הסופית המשתנה יאותחל לערך 60
        private int okCounter = 0;

        private string wordsScannerPlayer1 = "";
        private string wordsScannerPlayer2 = "";

        private int makesSenseCountPlayer1 = 0;
        private int makesSenseCountPlayer2 = 0;

        private string doesWordMakesSensePlayer1 = "";
        private string doesWordMakesSensePlayer2 = "";

        Form_Player1Won player1WinMessage = new Form_Player1Won();
        Form_Player2Won player2WinMessage = new Form_Player2Won();
        Form_Draw aTieMessage = new Form_Draw();

        private void playerTurnLabel()
        {
            playerTurn.Text = "Player 1 Turn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_IsFirstPlayer == true) // תור השחקן הראשון
            {
                if (counterPlayer1 < lettersPlayer1.Length)
                {
                    string buttonLettersPlayer1 = (sender as Button).Text;
                    lettersPlayer1[counterPlayer1] = buttonLettersPlayer1;

                    playerTurn.Text = "Player 1 Turn";

                    counterPlayer1++;
                    leftToChoosePlayer1--;

                    OkButton.Enabled = true;
                    DeleteButton.Enabled = true;

                    letterLeftToChoose.Text = leftToChoosePlayer1 + " letters left to choose...";
                    if (leftToChoosePlayer1 == 0)
                    {
                        letterLeftToChoose.Text = "Press OK to confirm your choise.";
                    }

                    (sender as Button).Enabled = false; // מכבה את הכפתורים שהשחקן הראשון לחץ עליהם

                    lettersBoxPlayer1.Items.Add(buttonLettersPlayer1);
                    // מוסיף את חמשת האותיות שהשחקן הראשון בחר לתיבת הרשימה
                }
            }
            // נגמר התור של השחקן הראשון והוא לוחץ על כפתור האישור

            // בעת הלחיצה על כפתור האישור מתחיל תור השחקן השני 
            else if (counterPlayer2 < lettersPlayer2.Length)
            {
                m_IsFirstPlayer = false; // השחקן הראשון סיים את תורו

                string buttonLettersPlayer2 = (sender as Button).Text;
                lettersPlayer2[counterPlayer2] = buttonLettersPlayer2;

                playerTurn.Text = "Player 2 Turn";

                counterPlayer2++;
                leftToChoosePlayer2--;

                letterLeftToChoose.Text = "5 letters left to choose...";

                letterLeftToChoose.Text = leftToChoosePlayer2 + " letters left to choose...";
                if (leftToChoosePlayer2 == 0)
                {
                    letterLeftToChoose.Text = "Press OK to confirm your choise.";
                }

                OkButton.Enabled = true;
                DeleteButton.Enabled = true;

                (sender as Button).Enabled = false; // מכבה את הכפתורים שהשחקן השני לחץ עליהם

                lettersBoxPlayer2.Items.Add(buttonLettersPlayer2);
                // מוסיף את חמשת האותיות שהשחקן השני בחר לתיבת הרשימה
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            lettersBoxPlayer1.Enabled = true;
            lettersBoxPlayer2.Enabled = true;

            playerTurn.Text = "Player 2 Turn";

            for (int i = 0; i < lettersPlayer1.Length; i++)
            {
                (sender as Button).Enabled = true;
            }

            addWordPlayer2Button.Enabled = true;
            addWordPlayer1Button.Enabled = true;

            m_IsFirstPlayer = false;

            okCounter++;

            if (okCounter > 1)
            {
                okCounter = 0;
                timer1.Start();

                lettersGroupBox.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void lettersBoxPlayer1_DoubleClick(object sender, EventArgs e)
        {
            if (Label_wordPlayer1.Text.Length <= 7)
            {
                Label_wordPlayer1.Text += lettersBoxPlayer1.SelectedItem.ToString();
            }
        }

        private void lettersBoxPlayer2_DoubleClick(object sender, EventArgs e)
        {
            if (Label_wordPlayer2.Text.Length <= 7)
            {
                Label_wordPlayer2.Text += lettersBoxPlayer2.SelectedItem.ToString();
            }
        }

        private void addWordPlayer1Button_Click(object sender, EventArgs e)
        {
            if (Label_wordPlayer1.Text.Length != 0)
                wordsBoxPlayer1.Items.Add(Label_wordPlayer1.Text);
            Label_wordPlayer1.Text = "";
        }

        private void addWordPlayer2Button_Click(object sender, EventArgs e)
        {
            if (Label_wordPlayer2.Text.Length != 0)
                wordsBoxPlayer2.Items.Add(Label_wordPlayer2.Text);
            Label_wordPlayer2.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button_MinuteTimer.Text = "Time left: " + timeCounter + ".00";
            timeCounter--;

            if (timeCounter == -1.00)
            {
                timer1.Stop();

                // הכנסת המילים שהורכבו על ידי השחקן הראשון לתיבת רשימה חדשה בצד ימין
                for (int i = 0; i < wordsBoxPlayer1.Items.Count; i++)
                {
                    wordsScannerPlayer1 = wordsBoxPlayer1.Items[i].ToString();
                    ListBox_ChosenWordsBoxPlayer1.Items.Add(wordsScannerPlayer1);
                }

                // הכנסת המילים שהורכבו על ידי השחקן השני לתיבת רשימה חדשה בצד ימין
                for (int i = 0; i < wordsBoxPlayer2.Items.Count; i++)
                {
                    wordsScannerPlayer2 = wordsBoxPlayer2.Items[i].ToString();
                    ListBox_ChosenWordsBoxPlayer2.Items.Add(wordsScannerPlayer2);
                }
            }
        }

        private void Button_player1_NotMakesSense_Click(object sender, EventArgs e)
        {
            ListBox_ChosenWordsBoxPlayer1.Items.Remove(ListBox_ChosenWordsBoxPlayer1.SelectedItem);
            doesWordMakesSensePlayer1 = "";
            Label_DoesWordMakesSensePlayer1.Text = "Next Word!";

            WinnerCheck();
        }

        private void Button_player2_NotMakesSense_Click(object sender, EventArgs e)
        {
            ListBox_ChosenWordsBoxPlayer2.Items.Remove(ListBox_ChosenWordsBoxPlayer2.SelectedItem);
            doesWordMakesSensePlayer2 = "";
            Label_DoesWordMakesSensePlayer2.Text = "Next Word!";

            WinnerCheck();
        }

        private void Button_player1_MakesSense_Click(object sender, EventArgs e)
        {
            makesSenseCountPlayer1++;
            Label_MakesSenseCountPlayer1.Text = "Makes sense words for Player 1: " + makesSenseCountPlayer1;
            Label_DoesWordMakesSensePlayer1.Text = "Next Word!";
            ListBox_ChosenWordsBoxPlayer1.Items.Remove(ListBox_ChosenWordsBoxPlayer1.SelectedItem);

            WinnerCheck();
        }

        private void Button_player2_MakesSense_Click(object sender, EventArgs e)
        {
            makesSenseCountPlayer2++;
            Label_MakesSenseCountPlayer2.Text = "Makes sense words for Player 2: " + makesSenseCountPlayer2;
            Label_DoesWordMakesSensePlayer2.Text = "Next Word!";
            ListBox_ChosenWordsBoxPlayer2.Items.Remove(ListBox_ChosenWordsBoxPlayer2.SelectedItem);

            WinnerCheck();
        }

        private void ListBox_ChosenWordsBoxPlayer1_DoubleClick(object sender, EventArgs e)
        {
            doesWordMakesSensePlayer1 = ListBox_ChosenWordsBoxPlayer1.SelectedItem.ToString();
            Label_DoesWordMakesSensePlayer1.Text = doesWordMakesSensePlayer1;

            WinnerCheck();
        }

        private void ListBox_ChosenWordsBoxPlayer2_DoubleClick(object sender, EventArgs e)
        {
            doesWordMakesSensePlayer2 = ListBox_ChosenWordsBoxPlayer2.SelectedItem.ToString();
            Label_DoesWordMakesSensePlayer2.Text = doesWordMakesSensePlayer2;

            WinnerCheck();
        }
        
        public void WinnerCheck()
        {
            if (ListBox_ChosenWordsBoxPlayer1.Items.Count == 0 && ListBox_ChosenWordsBoxPlayer2.Items.Count == 0)
            {
                if (makesSenseCountPlayer1 == makesSenseCountPlayer2)
                    aTieMessage.Show();

                else if (makesSenseCountPlayer1 > makesSenseCountPlayer2)
                    player1WinMessage.Show();

                else
                    player2WinMessage.Show();
            }
            
        }
    }
}
