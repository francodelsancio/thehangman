using HMController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/*
Universidad Tecnológica Nacional
Facultad Regional Tucuman
Tecnicatura Superior en Programación
Laboratorio de Computacion I
*/

namespace P3E00
{
    public partial class Ahorcado : Form
    {

        #region Properties

        private IAhorcadoController controller;

        private List<Button> LetterBoxs = new List<Button>();

        private List<Image> GuyPics = new List<Image>();

        private Timer Timer = new Timer();

        #endregion

        private Ahorcado()
        {
            InitializeComponent();
            SetImages();
            SetBoxs();
        }

        public Ahorcado(IAhorcadoController controller)
            :this()
        {
            this.controller = controller;
        }

        #region ViewButtons

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            pannelAddWord.Show();          
        }
   
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            CheckAndSetView(txtWord.Text);
        }

        private void btnArrow_Click(object sender, EventArgs e)
        {
            if (txtLetter.Text.Length != 1)
            {
                Message.Error("Solo se puede ingresar una letra.");
                return;
            }

            char letter = char.Parse(txtLetter.Text.ToUpper());

            CheckLetter(letter);
        }

        #endregion

        #region ViewEvents

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            MusicPlayer.PlayMusic(true);
        }

        private void ClearImage(object sender, EventArgs e)
        {
            picBoxStatus.Image = null;
            Timer.Stop();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            string word = (sender as TextBox).Text;

            if (word.Length > 3 && word.Length <= 11) btnAdd.Enabled = true;

            else btnAdd.Enabled = false;
        }

        private void txtLetter_TextChanged(object sender, EventArgs e)
        {
            if (!Entry.IsLetter(txtLetter.Text))
            {
                txtLetter.Text = string.Empty;

                return;
            }

            btnArrow.Enabled = true;
        }

        private new void MouseEnter(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            btn.Width += 3;
            btn.Height += 3;
        }

        private new void MouseLeave(object sender, EventArgs e)
        {
            var btn = (sender as Button);
            btn.Width -= 3;
            btn.Height -= 3;
        }

        #endregion

        #region HelperMethods

        private void CheckAndSetView(string word)
        {
            if (Entry.IsLetter(word))
            {
                controller.AddWord(word.ToUpper());
                SetupView(word);
            }
            else
            {
                Message.Error("Debe ingrear una palabra válida.");
                txtWord.Text = string.Empty;
            }
        }

        private void CheckLetter(char letter)
        {

            TestResult result = controller.TestLetter(letter);

            if (result.Success)
            {

                for (int i = 0; i < result.Letters.Count; i++)
                {
                    LetterBoxs[i].Text = result.Letters[i].ToString();
                }

                SetSuccesImage(true);
            
            } else
            {
                if (result.Message != null)
                {
                    Message.Error(result.Message);
                }

                SetFailedAttempt();
            }
                    
            if (controller.PayerHasWon())
            {
                Message.Success("GANASTE!");

                Reset();

            } else
            {
                txtLetter.Text = string.Empty;

                txtLetter.Focus();

                btnArrow.Enabled = false;
            }

        }

        private void SetFailedAttempt()
        {
            if (controller.GetAvailableAttempts() == 0)
            {
                lblRemain.Text = "0";
                Message.GameOver($"Perdiste! La palabra era {txtWord.Text.ToUpper()}.");
                Reset();
                return;
            }

            lblRemain.Text = controller.GetAvailableAttempts().ToString();

            int pictureNumber = controller.TotalAttempts() - controller.GetAvailableAttempts();

            picBoxGuy.Image = GuyPics[pictureNumber];

            SetSuccesImage(false);
        }

        private void SetSuccesImage(Boolean status)
        {
            MusicPlayer.PlayWoosh(true);

            picBoxStatus.Image = status ? Properties.Resources.ok : Properties.Resources.wrong;
            //Timmer for visual effect
            Timer.Tick += new EventHandler(ClearImage);
            Timer.Interval = 1500;
            Timer.Start();
        }

        private void HideBoxes(int box)
        {
            for (int i = 0; i < LetterBoxs.Count; i++)
            {
                if (i < box) LetterBoxs[i].Show();

                else LetterBoxs[i].Hide();
            }
        }

        #endregion

        #region SetupView

        private void SetupView(string word)
        {
            MusicPlayer.PlayMusic(false);
            MusicPlayer.PlayWoosh(true);
            picBoxRope.Hide();
            picBoxGuy.Image = null;
            pannelRemain.Show();
            pannelAddWord.Hide();
            pannelGame.Show();
            HideBoxes(word.Length);
            txtLetter.Focus();

            try
            {
                picBoxStatus.Location = LetterBoxs[word.Length].Location;
                picBoxStatus.Top -= 10;
            }
            catch
            {
                picBoxStatus.Location = pannelRemain.Location;
            }
        }

        private void Reset()
        {
            controller.ResetController();
            lblRemain.Text = controller.TotalAttempts().ToString();
            txtWord.Text = string.Empty;
            txtLetter.Text = string.Empty;
            LetterBoxs.ForEach(box => box.Text = string.Empty);
            picBoxRope.Show();
            picBoxGuy.Image = null;
            pannelGame.Hide();
            pannelAddWord.Hide();
            pannelRemain.Hide();
            btnStart.Show();
            MusicPlayer.PlayMusic(true);
        }


        private void SetBoxs()
        {
            LetterBoxs.Add(btnLetter0);
            LetterBoxs.Add(btnLetter1);
            LetterBoxs.Add(btnLetter2);
            LetterBoxs.Add(btnLetter3);
            LetterBoxs.Add(btnLetter4);
            LetterBoxs.Add(btnLetter5);
            LetterBoxs.Add(btnLetter6);
            LetterBoxs.Add(btnLetter7);
            LetterBoxs.Add(btnLetter8);
            LetterBoxs.Add(btnLetter9);
            LetterBoxs.Add(btnLetter10);

        }

        private void SetImages()
        {
            GuyPics.Add(Properties.Resources.Ahorcado0);
            GuyPics.Add(Properties.Resources.Ahorcado1);
            GuyPics.Add(Properties.Resources.Ahorcado2);
            GuyPics.Add(Properties.Resources.Ahorcado3);
            GuyPics.Add(Properties.Resources.Ahorcado4);
            GuyPics.Add(Properties.Resources.Ahorcado5);
            GuyPics.Add(Properties.Resources.Ahorcado6);
            GuyPics.Add(Properties.Resources.Ahorcado7);
            GuyPics.Add(Properties.Resources.Ahorcado8);
        }

        #endregion
    }
}
