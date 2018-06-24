
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


/*
Universidad Tecnológica Nacional
Facultad Regional Tucuman
Tecnicatura Superior en Programación
Laboratorio de Cumputacion I
*/


namespace P3E00
{


    public partial class Ahorcado : Form
    {

        private List<Button> LetterBoxs = new List<Button>();

        private List<Image> GuyPics = new List<Image>();

        private List<char> Word = new List<char>();

        private List<char> EntryWord = new List<char>();

        private Player Player = new Player();

        private Timer Timer = new Timer();

        private char _letter;
        private int _counter = 8;
        private int _wins = 0;
       

        public Ahorcado()
        {
            InitializeComponent();

            SetImages();

            SetBoxs();

        }

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            Player.PlayMusic(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            pannelAddWord.Show();          
        }

   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckAndSet();
        }


        private void CheckAndSet()
        {
            // paro la musica y oculto imagen principal
            Player.PlayMusic(false);

            Player.PlayWoosh(true);

            picBoxRope.Hide();


            //chequeo si hay letras y asigno al array
            if (!HasLetters(txtWord.Text))
            {
                MessageBox.Show("Debe ingrear una palabra valida", "Mensaje");
            }
            else
            {

                string word = txtWord.Text.ToUpper();

                foreach (var letter in word)
                {
                    Word.Add(letter);

                }

                // Muestro los paneles para el juego
                picBoxGuy.Image = null;
                pannelRemain.Show();
                pannelAddWord.Hide();
                pannelGame.Show();

                // Se ocultan los casilleros que no se necesitan
                HideLetterBoxes(word.Length);

                // Posiciono la imagen para mostrar correcto e incorrecto
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
        }


        /// <summary>
        /// Chequea que el string contenga solo letras
        /// </summary>
        /// <param name="letters"> Texto a controlar</param>
        /// <returns> Verdadero si es solo letras </returns>
        private Boolean HasLetters(string letters)
        {
            char[] _letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string words = letters.ToUpper();

            return words.IndexOfAny(_letters) >= 0;

        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            //Si se ingresa palabra con tam mayor que 3 y menor e igual que 11, se juega.

            string word = (sender as TextBox).Text;

            if (word.Length > 3 && word.Length <=11 ) btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
          
        }


        private void txtLetter_TextChanged(object sender, EventArgs e)

        {
            
            //Si no es letra retorno
            if (!HasLetters(txtLetter.Text))
            {
                txtLetter.Text = string.Empty;
                return;
            }

            // Si es una letra activo el boton flecha
            if (txtLetter.Text.Length == 1)
            {
                _letter = char.Parse(txtLetter.Text.ToUpper());

                btnArrow.Enabled = true;
            } 
        }


        private void btnArrow_Click(object sender, EventArgs e)
        {
            CheckLetter();
        }

        private void CheckLetter()
        {
            //Chequeo si hay letras
            if (txtLetter.Text.Length != 1) return;

            //Chequeo si no utilizo esa letra antes
            if (EntryWord.Contains(_letter))
            {
                MessageBox.Show("Ya utilizo esa letra!", "Atencion");
                txtLetter.Text = string.Empty;
                return;
            }

            //Guardo letra ingresada
            EntryWord.Add(_letter);

            Boolean _missed = true;

            //Verifico si es correcto o no, si no es correcto missed (errado) sigue true
            for (int i = 0; i < Word.Count; i++)
            {

                if (_letter == Word[i])
                {
                    LetterBoxs[i].Text = _letter.ToString();
                    _missed = false;
                    ShowIsCorrectLetter(true);
                    _wins++;
                }
            }

 
            //Verifico si gano
            if (_wins == Word.Count)
            {
                MessageBox.Show("GANASTE!","Felicidades!");
                Reset();
                return;
            }

            //Si no gano o la letra no fue correcta
            if (_missed)
            {
                SetMissed();
            }

            //Espero otra letra
            txtLetter.Text = string.Empty;
            txtLetter.Focus();

            btnArrow.Enabled = false;
        }

        /// <summary>
        /// Muestra la interface en modo palabra incorrecta
        /// </summary>
        private void SetMissed()
        {
            if (_counter == 0)
            {
                lblRemain.Text = "0";
                MessageBox.Show($"Perdiste! La palabra era {txtWord.Text.ToUpper()}.", "Lo siento");
                Reset();
                return;
            }

            lblRemain.Text = _counter--.ToString();

            picBoxGuy.Image = GuyPics[7 - _counter];

            ShowIsCorrectLetter(false);


        }

        /// <summary>
        /// Muestra la imagen y reproduce sonido de letra correcta o incorrecta
        /// </summary>
        /// <param name="status"> Es correcto (true) o no (false) </param>
        private void ShowIsCorrectLetter(Boolean status)
        {

            Player.PlayWoosh(true);

            picBoxStatus.Image = status ? Properties.Resources.ok : Properties.Resources.wrong;

            //Timmer
            Timer.Tick += new EventHandler(ClearImage);
            Timer.Interval = 1500;
            Timer.Start();
         
         
        
        }
        private void ClearImage(object sender, EventArgs e)
        {

            picBoxStatus.Image = null;
            Timer.Stop();
        }
        /// <summary>
        /// Esconde las cajas de text
        /// </summary>
        /// <param name="box"> Numero de cajas a mostrar</param>
        private void HideLetterBoxes(int box)
        {
            for (int i = 0; i < LetterBoxs.Count; i++)
            {
                if (i < box) LetterBoxs[i].Show();
                else LetterBoxs[i].Hide();
            }
          
        }


        /// <summary>
        /// Vuelve a la pantalla principal con valores por default
        /// </summary>
        private void Reset()
        {
            _counter = 8;
            _wins = 0;
            lblRemain.Text = "8";
            txtWord.Text = string.Empty;
            txtLetter.Text = string.Empty;
            LetterBoxs.ForEach( box => box.Text = string.Empty);
            Word.Clear();
            EntryWord.Clear();
            picBoxRope.Show();
            picBoxGuy.Image = null;
            pannelGame.Hide();
            pannelAddWord.Hide();
            pannelRemain.Hide();
            btnStart.Show();
            Player.PlayMusic(true);
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
    }
}
