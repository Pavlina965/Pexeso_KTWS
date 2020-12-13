using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pexeso
{
    public partial class Game : Form
    {
        Label clickedFirst = null;
        Label clickedSecond = null;
        
        
        public Game()
        {
            InitializeComponent();
            AssignNumbersToSquares();
        }

        int guessed = 0;
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
            if (timer1.Enabled == true || clickedSecond !=null)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor != clickedLabel.BackColor)
                    return;

                if (clickedFirst == null)
                {
                    clickedFirst = clickedLabel;
                    clickedFirst.ForeColor = Color.Black;
                    return;
                }
                if (clickedFirst!= null & clickedSecond == null)
                {
                    clickedSecond = clickedLabel;
                    clickedSecond.ForeColor = Color.Black;
                    if (clickedFirst.Text == clickedSecond.Text)
                    {
                        clickedFirst = null;
                        clickedSecond = null;
                        guessed++;
                        if (guessed == 10)
                        {
                            MessageBox.Show("vyhra");
                        }

                        return;
                    }
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            clickedFirst.ForeColor = clickedFirst.BackColor;
            clickedSecond.ForeColor = clickedSecond.BackColor;
            clickedFirst = null;
            clickedSecond = null;
        }
    } 
}
