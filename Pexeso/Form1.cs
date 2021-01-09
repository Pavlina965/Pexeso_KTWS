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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void NewGame_Click_1(object sender, EventArgs e)
        {
            
            var newGame = new Game();
            newGame.Show();
            this.Hide();

        }

        private void Score_Click(object sender, EventArgs e)
        {
            
            var scoreBoard = new ScoreBoard();
            scoreBoard.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
