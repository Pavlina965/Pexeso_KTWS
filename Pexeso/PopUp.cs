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
            this.TimeLabel.Text = ("vaše hra trvala: " + Game.duration +" počet kliků "+ Game.kliky); 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void BackButton_Click(object sender, EventArgs e)
        {
            
            var hra = new Game();
            hra.Close();
            this.Close();
            var Form1 = new Form1();
            Form1.Show();

        }

        private void SaveScoreButton_Click(object sender, EventArgs e)//ukladaní,casu hry, poctu kliku a jmena do databaze
        {

            string jmeno = JmenoHrace.Text;
            Score score = new Score();
            score.Jmeno = jmeno;
            score.Cas = Game.duration;
            score.PocetKliku = Game.kliky;
            Program.ScoreDatabase.SaveItemAsync(score);
            var hra = new Game();
            hra.Close();
            this.Close();
            var ScoreBoard = new ScoreBoard();
            ScoreBoard.Show();
        }
    }
}
