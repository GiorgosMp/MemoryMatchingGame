using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMatchingGame
{
    public partial class GameWindow : Form
    {
        //Δήλωση μεταβλητών
        bool x = false;
        //Θέτει μια τυχαία θέση για κάθε κάρτα
        Random r = new Random();

        int w = 0;

        //Λίστα που αποθηκεύει το ξεχωριστό σημείο-σημάδι της κάθε κάρτας
        List<Point> p = new List<Point>();

        //Το FirstClicked δείχνει στο πρώτο PictureBox που θα πατήσει ο παίκτης
        //θα είναι null όσο ο παίκτης δεν έχει πατήσει κάποιο PictureBox
        PictureBox FirstClicked = null;

        //Το SecondClicked δείχνει στο δεύτερο PictureBox που θα πατήσει ο παίκτης
        PictureBox SecondClicked = null;

        public GameWindow()
        {
            InitializeComponent();

        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in CardsHolder.Controls)
                picture.Enabled = false;
        }

        //Έλεγχος Καρτών
        #region Κάρτες

        private void Card1_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card1.Image = Properties.Resources.image1;
            else
                Card1.ImageLocation = "UploadPics/pic1.jpg";
            if (FirstClicked == null)
                FirstClicked = Card1;
            else if (SecondClicked == null)
                SecondClicked = Card1;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                 }
                 else
                    timer3.Start();
            }
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard1.Image = Properties.Resources.image1;
            else
                DupCard1.ImageLocation = "UploadPics/pic1.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard1;
            else if (SecondClicked == null)
                SecondClicked = DupCard1;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start(); 
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card2.Image = Properties.Resources.image2;
            else
                Card2.ImageLocation = "UploadPics/pic2.jpg";
            if (FirstClicked == null)
                FirstClicked = Card2;
            else if (SecondClicked == null)
                SecondClicked = Card2;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard2.Image = Properties.Resources.image2;
            else
                DupCard2.ImageLocation = "UploadPics/pic2.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard2;
            else if (SecondClicked == null)
                SecondClicked = DupCard2;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card3.Image = Properties.Resources.image3;
            else
                Card3.ImageLocation = "UploadPics/pic3.jpg";
            if (FirstClicked == null)
                FirstClicked = Card3;
            else if (SecondClicked == null)
                SecondClicked = Card3;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard3.Image = Properties.Resources.image3;
            else
                DupCard3.ImageLocation = "UploadPics/pic3.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard3;
            else if (SecondClicked == null)
            {
                SecondClicked = DupCard3;
            }
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card4.Image = Properties.Resources.image4;
            else
                Card4.ImageLocation = "UploadPics/pic4.jpg";
            if (FirstClicked == null)
                FirstClicked = Card4;
            else if (SecondClicked == null)
                SecondClicked = Card4;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard4.Image = Properties.Resources.image4;
            else
                DupCard4.ImageLocation = "UploadPics/pic4.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard4;
            else if (SecondClicked == null)
                SecondClicked = DupCard4;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card5.Image = Properties.Resources.image5;
            else
                Card5.ImageLocation = "UploadPics/pic5.jpg";
            if (FirstClicked == null)
                FirstClicked = Card5;
            else if (SecondClicked == null)
                SecondClicked = Card5;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard5.Image = Properties.Resources.image5;
            else
                DupCard5.ImageLocation = "UploadPics/pic5.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard5;
            else if (SecondClicked == null)
                SecondClicked = DupCard5;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card6.Image = Properties.Resources.image6;
            else
                Card6.ImageLocation = "UploadPics/pic6.jpg";
            if (FirstClicked == null)
                FirstClicked = Card6;
            else if (SecondClicked == null)
                SecondClicked = Card6;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard6.Image = Properties.Resources.image6;
            else
                DupCard6.ImageLocation = "UploadPics/pic6.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard6;
            else if (SecondClicked == null)
                SecondClicked = DupCard6;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card7.Image = Properties.Resources.image7;
            else
                Card7.ImageLocation = "UploadPics/pic7.jpg";
            if (FirstClicked == null)
                FirstClicked = Card7;
            else if (SecondClicked == null)
                SecondClicked = Card7;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard7.Image = Properties.Resources.image7;
            else
                DupCard7.ImageLocation = "UploadPics/pic7.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard7;
            else if (SecondClicked == null)
                SecondClicked = DupCard7;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card8.Image = Properties.Resources.image8;
            else
                Card8.ImageLocation = "UploadPics/pic8.jpg";
            if (FirstClicked == null)
                FirstClicked = Card8;
            else if (SecondClicked == null)
                SecondClicked = Card8;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard8.Image = Properties.Resources.image8;
            else
                DupCard8.ImageLocation = "UploadPics/pic8.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard8;
            else if (SecondClicked == null)
                SecondClicked = DupCard8;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card9.Image = Properties.Resources.image9;
            else
                Card9.ImageLocation = "UploadPics/pic9.jpg";
            if (FirstClicked == null)
                FirstClicked = Card9;
            else if (SecondClicked == null)
                SecondClicked = Card9;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard9_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard9.Image = Properties.Resources.image9;
            else
                DupCard9.ImageLocation = "UploadPics/pic9.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard9;
            else if (SecondClicked == null)
                SecondClicked = DupCard9;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card10.Image = Properties.Resources.image10;
            else
                Card10.ImageLocation = "UploadPics/pic10.jpg";
            if (FirstClicked == null)
                FirstClicked = Card10;
            else if (SecondClicked == null)
                SecondClicked = Card10;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard10_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard10.Image = Properties.Resources.image10;
            else
                DupCard10.ImageLocation = "UploadPics/pic10.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard10;
            else if (SecondClicked == null)
                SecondClicked = DupCard10;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card11.Image = Properties.Resources.image11;
            else
                Card11.ImageLocation = "UploadPics/pic11.jpg";
            if (FirstClicked == null)
                FirstClicked = Card11;
            else if (SecondClicked == null)
                SecondClicked = Card11;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void DupCard11_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard11.Image = Properties.Resources.image11;
            else
                DupCard11.ImageLocation = "UploadPics/pic11.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard11;
            else if (SecondClicked == null)
                SecondClicked = DupCard11;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                Card12.Image = Properties.Resources.image12;
            else
                Card12.ImageLocation = "UploadPics/pic12.jpg";
            if (FirstClicked == null)
                FirstClicked = Card12;
            else if (SecondClicked == null)
                SecondClicked = Card12;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DupCard12_Click(object sender, EventArgs e)
        {
            if (!uploadpics)
                DupCard12.Image = Properties.Resources.image12;
            else
                DupCard12.ImageLocation = "UploadPics/pic12.jpg";
            if (FirstClicked == null)
                FirstClicked = DupCard12;
            else if (SecondClicked == null)
                SecondClicked = DupCard12;
            if (FirstClicked != null && SecondClicked != null)
            {
                if (FirstClicked.Tag == SecondClicked.Tag)
                {
                    FirstClicked = null;
                    SecondClicked = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
                    winner();
                }
                else
                    timer3.Start();
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();
            timer4.Start();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                //Ενεργοποίηση όλων των καρτών αφού αναποδογυρίσουν όλες
                picture.Enabled = true;

                //Όταν ενεργοποιούνται οι εικόνες πάνω από κάθε εικόνα έχουμε το χεράκι
                picture.Cursor = Cursors.Hand;

                //Τοποθέτηση σε κάθε picturebox το cover
                picture.Image = Properties.Resources.cover;
            }
        }

        //Αντίστροφη μέτρηση για την έναρξη του παιχνιδιού
        //Αρχικά όλες οι κάρτες είναι ανοιχτές για 5'' και μετά αναποδογυρίζουν
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Μετατρέπουμε σε μορφή integer το περιεχόμενο του label2 που είναι η αντίστροφη μέτρηση
            int timer = Convert.ToInt32(label2.Text);

            //Μείωση κατά ένα της τιμής του timer
            timer = timer - 1;

            //Επειδή το label2 παίρνει τιμές κειμένου μετατρέπουμε την τιμή που θα έχει ο timer σε string
            label2.Text = Convert.ToString(timer);

            //Όταν η τιμή του timer θα έιναι ίση με μηδέν
            //αυτό σημαίνει πως ήρθε η ώρα να ξεκινήσει το παιχνίδι
            if (timer == 0)
                //Η αντίστροφη μέτρηση σταματά άρα σταματά και ο timer2
                timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            FirstClicked.Image = Properties.Resources.cover;
            SecondClicked.Image = Properties.Resources.cover;
            FirstClicked = null;
            SecondClicked = null;
            ScoreKeeper.Text = Convert.ToString(Convert.ToInt32(ScoreKeeper.Text) + 1);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(label1.Text);
            t = t + 1;
            label1.Text = Convert.ToString(t);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void winner()
        {
            w = w + 1;

            if (w == 12)
            {
                timer4.Stop();
                Form2 f2 = new Form2();
                f2.time = label1.Text;
                f2.attempts = ScoreKeeper.Text;
                f2.ShowDialog();
            }
        }

        bool uploadpics = false;
        private void uploadPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uploadpics = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            
            //Το φίλτρο εικόνας περιορίζει τον χρήστη να επιλέξει μόνο έγκυρα αρχεία εικόνας
            ofd.Filter = "Image Files(*.jpg;)|*.jpg;";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { }
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                //Απενεργοποίηση όλων των καρτών πριν την έναρξη του παιχνιδιού
                //προκειμένου να μην υπολογιστεί οποιαδήποτε επιλογή καρτών γίνει 
                //πρίν το αναποδογύρισμα των καρτών
                picture.Enabled = false;

                //Θέτουμε για κάθε θέση μιας εικόνας ένα ξεχωριστό σημείο
                //από τη λίστα τύπου Points
                p.Add(picture.Location);
            }

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = r.Next(p.Count);
                Point _point = p[next];
                picture.Location = _point;
                p.Remove(_point);
            }


            //Τοποθέτηση των εικόνων σε κάθε picturebox το οποίο έχει μοναδικό όνομα για ευκολία
            //τις εικόνες τις πέρνουμε από τα resources όπου τις κάναμε προηγουμένως import
            if (!uploadpics)
            {
                #region Τοποθέτηση εικόνων
                Card1.Image = Properties.Resources.image1;
                DupCard1.Image = Properties.Resources.image1;
                Card2.Image = Properties.Resources.image2;
                DupCard2.Image = Properties.Resources.image2;
                Card3.Image = Properties.Resources.image3;
                DupCard3.Image = Properties.Resources.image3;
                Card4.Image = Properties.Resources.image4;
                DupCard4.Image = Properties.Resources.image4;
                Card5.Image = Properties.Resources.image5;
                DupCard5.Image = Properties.Resources.image5;
                Card6.Image = Properties.Resources.image6;
                DupCard6.Image = Properties.Resources.image6;
                Card7.Image = Properties.Resources.image7;
                DupCard7.Image = Properties.Resources.image7;
                Card8.Image = Properties.Resources.image8;
                DupCard8.Image = Properties.Resources.image8;
                Card9.Image = Properties.Resources.image9;
                DupCard9.Image = Properties.Resources.image9;
                Card10.Image = Properties.Resources.image10;
                DupCard10.Image = Properties.Resources.image10;
                Card11.Image = Properties.Resources.image11;
                DupCard11.Image = Properties.Resources.image11;
                Card12.Image = Properties.Resources.image12;
                DupCard12.Image = Properties.Resources.image12;
                #endregion
            }
            else
            {
                Card1.ImageLocation = "UploadPics/pic1.jpg";
                Card2.ImageLocation = "UploadPics/pic2.jpg";
                Card3.ImageLocation = "UploadPics/pic3.jpg";
                Card4.ImageLocation = "UploadPics/pic4.jpg";
                Card5.ImageLocation = "UploadPics/pic5.jpg";
                Card6.ImageLocation = "UploadPics/pic6.jpg";
                Card7.ImageLocation = "UploadPics/pic7.jpg";
                Card8.ImageLocation = "UploadPics/pic8.jpg";
                Card9.ImageLocation = "UploadPics/pic9.jpg";
                Card10.ImageLocation = "UploadPics/pic10.jpg";
                Card11.ImageLocation = "UploadPics/pic11.jpg";
                Card12.ImageLocation = "UploadPics/pic12.jpg";
                DupCard1.ImageLocation = "UploadPics/pic1.jpg";
                DupCard2.ImageLocation = "UploadPics/pic2.jpg";
                DupCard3.ImageLocation = "UploadPics/pic3.jpg";
                DupCard4.ImageLocation = "UploadPics/pic4.jpg";
                DupCard5.ImageLocation = "UploadPics/pic5.jpg";
                DupCard6.ImageLocation = "UploadPics/pic6.jpg";
                DupCard7.ImageLocation = "UploadPics/pic7.jpg";
                DupCard8.ImageLocation = "UploadPics/pic8.jpg";
                DupCard9.ImageLocation = "UploadPics/pic9.jpg";
                DupCard10.ImageLocation = "UploadPics/pic10.jpg";
                DupCard11.ImageLocation = "UploadPics/pic11.jpg";
                DupCard12.ImageLocation = "UploadPics/pic12.jpg";
            }

            ScoreKeeper.Text = Convert.ToString(0);
            label1.Text = Convert.ToString(0);
            label2.Text = Convert.ToString(5);
            timer2.Start();
            timer1.Start();
            timer4.Stop();
            w = 0;
        }
    }
}
