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
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
            this.JmenoHrace.Hide();
            this.TimeLabel.Text = ("vaše hra trvala: " + Game.duration +" počet kliků "+ Game.kliky); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void BackButton_Click(object sender, EventArgs e)
        {
            
            var Game = new Game();
            Game.Close();
            this.Close();
            var Form1 = new Form1();
            Form1.Show();
            
        }

        private void SaveScoreButton_Click(object sender, EventArgs e)
        {
           this.JmenoHrace.Show();
            
            

           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string jmeno = JmenoHrace.Text;
            Score score = new Score();
            score.Jmeno = jmeno;
            score.Cas = Game.duration;
            score.PocetKliku = Game.kliky;
            Program.ScoreDatabase.SaveItemAsync(score);

        }
    }
}
