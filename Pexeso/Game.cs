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
        
        
        public Game()
        {
            InitializeComponent();
            AssignNumbersToSquares();// tato funkce přidá náhodně čísla do labelu pro rozhozeni hraci plochy
            stopWach.Start();
        }

        int guessed = 0; //pomoc při počítání správně vybraných dvojic
        Random r = new Random();
        List<string> icons = new List<string>()
        {
            "1","1","2","2","3","3","4","4","5","5","6","6","7","7","8","8","9","9","10","10"
        };

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

        private void label_click(object sender, EventArgs e)
        {

            TimeSpan ts = stopWach.Elapsed;

            if (timer1.Enabled == true || clickedSecond !=null)
                return;

            Label clickedLabel = sender as Label;
            
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor != clickedLabel.BackColor)//ošetření aby nedošlo ke zvolení již zvoleného pole
                    return;

                if (clickedFirst == null)//výběr prvního políčka
                {
                    clickedFirst = clickedLabel;
                    clickedFirst.ForeColor = Color.Black;
                    return;
                }
                if (clickedFirst!= null & clickedSecond == null)//výběr druhého políčka
                {
                    clickedSecond = clickedLabel;
                    clickedSecond.ForeColor = Color.Black;
                    if (clickedFirst.Text == clickedSecond.Text)//ověření zda byly vybrany stejné "obrázky"
                    {
                        clickedFirst = null;
                        clickedSecond = null;
                        guessed++;
                        if (guessed == 10)
                        {
                            stopWach.Stop();
                           
                            string duration = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
                            MessageBox.Show("vyhra" + " vaše hra trvala "+ duration);                     }

                        return;
                    }
                    timer1.Start();
                    
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)// znovu zneviditelneni hracich poli pokud nebyly vybrany stejne pole
        {
            timer1.Stop();
            clickedFirst.ForeColor = clickedFirst.BackColor;
            clickedSecond.ForeColor = clickedSecond.BackColor;
            clickedFirst = null;
            clickedSecond = null;
        }

    } 
}
