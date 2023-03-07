using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HangMan.Internals;
using HangMan.Methods;

namespace HangMan
{
    public partial class HangManMainView : Form
    {
        private string _secretWord;
        private string _userGuessedWord;
        private List<string> _usedLettersList;
        private WordLoader _wordLoader;
        private int _trialNumber;
        private ApplicationSettings ApplicationSettings;

        public HangManMainView()
        {
            InitializeComponent();

            //Constructors
            ApplicationSettings = new ApplicationSettings();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            picB_HangmanPicture.BackColor = Color.White;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string LoadRandomWord()
        {
            _wordLoader = new WordLoader();
            return _wordLoader.RandomizedWord();
        }

        private void HangMan_MainView_Load(object sender, EventArgs e)
        {
            //During Load, The first word should be loaded and stored as a variable
            //And the Textbox should have "?" for each letter.

            //Load a new word as a start and reset everything.
            trials_progressBar.Value = 0;
            tryLetter_textBox.Enabled = false;
            newGameToolStripMenuItem_Click(this, EventArgs.Empty);

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new secret word from file
            _secretWord = LoadRandomWord();

            //Update the box showing the number of letters
            secretWord_textBox.Text = _wordLoader.SecretWordCreator(_secretWord);
            _userGuessedWord = secretWord_textBox.Text;
            //Create a list with all used letters.
            _usedLettersList = new List<string>();
            usedLetters_textBox.Text = "";

            //Enable the letterbox.
            tryLetter_textBox.Text = "";            
            tryLetter_textBox.Enabled = true;

            //Reset the number of trials the user have
            trials_progressBar.Value = 7;
            _trialNumber = 0;
            Update();
        }

        private bool CheckTextBoxInput_Ok(TextBox t, ErrorProvider e)
        {
            //We must have at least a letter in the box. If there are more it is also wrong
            if (t.Text.All(char.IsLetter))
            {
                e.Clear();
                return true;
            }
            else
            {
                e.SetError(t, "A letter needs to be filled!!!");
                return false;                
            }
        }

        private void tryLetter_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            //Is it a valid letter? If so continue otherwise do nothing.
            if (CheckTextBoxInput_Ok(tryLetter_textBox, errorProvider1))
            {

                //Have we used this letter before and it is a valid character? 
                if (!_usedLettersList.Contains(tryLetter_textBox.Text) && Regex.IsMatch(tryLetter_textBox.Text, @"^[a-zA-Z\dåäöÅÄÖ-]*$"))
                {

                    //if letter exists in the word we are looking for lets go further.
                    if (_wordLoader.CheckGuessForMatch(tryLetter_textBox.Text, _secretWord))
                    {
                        _userGuessedWord = _wordLoader.ReplaceSecretwordWithLetter(tryLetter_textBox.Text, _secretWord, _userGuessedWord);
                        secretWord_textBox.Text = _userGuessedWord;
                    }
                    else
                    {
                        //Update UsedLetter box and add Letter to List
                        usedLetters_textBox.Text = usedLetters_textBox.Text + tryLetter_textBox.Text + ", ";

                        //Update the number of trials left
                        trials_progressBar.Value--;

                        //Update Drawing and trials
                        HangManMainView_Paint(sender, null);
                        _trialNumber++;
                    }

                    //Reset the UI for next trial
                    _usedLettersList.Add(tryLetter_textBox.Text);
                    tryLetter_textBox.Text = "";

                }
                else //We did not have a match.
                {
                    tryLetter_textBox.Text = "";
                    errorProvider1.SetError(tryLetter_textBox, "Either a faulty or a used character choosen. Please try again");
                }
            }

            if (trials_progressBar.Value == 0)
            {
                MessageBox.Show($"Your are hung!!! Lets resurrect and try again. \n\r Secret word was: '{_secretWord}'", "Your D.E.A.D", MessageBoxButtons.OK);
                newGameToolStripMenuItem_Click(this, EventArgs.Empty);
            }

            if(!secretWord_textBox.Text.Contains("?"))
            {
                MessageBox.Show("Well Done!!! You guessed the correct word", "Your a winner", MessageBoxButtons.OK);
                newGameToolStripMenuItem_Click(this, EventArgs.Empty);
            }

        }

        private void HangManMainView_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // Set the pen and graphics that we are drawing with;
                var g = picB_HangmanPicture.CreateGraphics();
                var p = new Pen(Color.Black);

                //Get the correct line to draw from ApplicationSettings
                var line = ApplicationSettings.HangmanAnatomies(picB_HangmanPicture.Size.Width / 2, picB_HangmanPicture.Size.Height).FirstOrDefault(x => x.AnatomyLineNumber == _trialNumber);

                //Straight Lines
                g.DrawLine(p, line.LineStartPoint, line.LineEndPoint);

                //Circle

            }
            catch { }
        }
    }
}
