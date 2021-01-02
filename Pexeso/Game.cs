using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Pexeso
{
    public partial class Game : Form
    {
        Label clickedFirst = null;
        Label clickedSecond = null;
        Stopwatch stopWach = new Stopwatch();
        public static string duration;

        public Game()
        {

            InitializeComponent();

            AssignNumbersToSquares();// tato funkce přidá náhodně čísla do labelu pro rozhozeni hraci plochy



            stopWach.Start();

        }

        int guessed = 0; //pomoc při počítání správně vybraných dvojic
        public static int kliky = 0;
        Random r = new Random();
        List<string> icons = new List<string>()
        {
            "1","1","2","2","3","3","4","4","5","5","6","6","7","7","8","8","9","9","10","10"
        };
        private static string cesta = AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\kocky\\";
        Image cat1 = Image.FromFile(cesta + "/kocka1.jpg");
        Image cat2 = Image.FromFile(cesta + "kocka2.jpg");
        Image cat3 = Image.FromFile(cesta + "kocka3.jpg");
        Image cat4 = Image.FromFile(cesta + "kocka4.jpg");
        Image cat5 = Image.FromFile(cesta + "kocka5.jpg");
        Image cat6 = Image.FromFile(cesta + "kocka6.jpg");
        Image cat7 = Image.FromFile(cesta + "kocka7.jpg");
        Image cat8 = Image.FromFile(cesta + "kocka8.jpg");
        Image cat9 = Image.FromFile(cesta + "kocka9.jpg");
        Image cat10 = Image.FromFile(cesta + "kocka10.jpg");
        
        private Image ShowImage(Label iconLabel)
        {
            switch (iconLabel.Text)
            {
                case "1":

                    iconLabel.Image = resizeImage(cat1, new Size(label1.Width, label1.Height));
                    break;

                case "2":
                    iconLabel.Image = resizeImage(cat2, new Size(label1.Width, label1.Height));
                    break;
                case "3":
                    iconLabel.Image = resizeImage(cat3, new Size(label1.Width, label1.Height));
                    break;
                case "4":
                    iconLabel.Image = resizeImage(cat4, new Size(label1.Width, label1.Height));
                    break;
                case "5":
                    iconLabel.Image = resizeImage(cat5, new Size(label1.Width, label1.Height));
                    break;
                case "6":
                    iconLabel.Image = resizeImage(cat6, new Size(label1.Width, label1.Height));
                    break;
                case "7":
                    iconLabel.Image = resizeImage(cat7, new Size(label1.Width, label1.Height));
                    break;
                case "8":
                    iconLabel.Image = resizeImage(cat8, new Size(label1.Width, label1.Height));
                    break;
                case "9":
                    iconLabel.Image = resizeImage(cat9, new Size(label1.Width, label1.Height));
                    break;
                case "10":
                    iconLabel.Image = resizeImage(cat10, new Size(label1.Width, label1.Height));
                    break;
            }
            return iconLabel.Image;
        }
        private void AssignNumbersToSquares()
        {
           
 
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = r.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
               
                iconLabel.ForeColor = iconLabel.BackColor;
               
            }

        }



        
        public void label_click(object sender, EventArgs e)
        {

            TimeSpan ts = stopWach.Elapsed;

            if (timer1.Enabled == true || clickedSecond !=null)
                return;

            Label clickedLabel = sender as Label;
            
            if (true)
            {
                if (clickedLabel.Image != null)//ošetření aby nedošlo ke zvolení již zvoleného pole
                    return;

                if (clickedFirst == null)//výběr prvního políčka
                {
                    clickedFirst = clickedLabel;
                    clickedFirst.Image = ShowImage(clickedLabel);
                    kliky++;
                    return;
                }
                if (clickedFirst!= null & clickedSecond == null)//výběr druhého políčka
                {
                    clickedSecond = clickedLabel;
                    clickedSecond.Image = ShowImage(clickedLabel);
                    kliky++;
                    if (clickedFirst.Text == clickedSecond.Text)//ověření zda byly vybrany stejné "obrázky"
                    {
                        clickedFirst = null;
                        clickedSecond = null;
                        guessed++;
                        if (guessed == 10)
                        {
                            stopWach.Stop();
                           
                            duration = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
                            var PopUp = new PopUp();
                            PopUp.Show();
                            this.Close();
                        }

                        return;
                    }
                    timer1.Start();
                    
                }
            }

        }
        private static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void timer1_Tick(object sender, EventArgs e)// znovu zneviditelneni hracich poli pokud nebyly vybrany stejne pole
        {
            timer1.Stop();
            clickedFirst.Image = null;
            clickedSecond.Image = null;
            clickedFirst = null;
            clickedSecond = null;
        }


    } 
}
