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
    public partial class ScoreBoard : Form
    {


        public ScoreBoard()
        {
            InitializeComponent();
            dataGridScore.View = View.Details;
            dataGridScore.Columns.Add("ID", -1, HorizontalAlignment.Left); //vytvoreni sloupcu v okne
            dataGridScore.Columns.Add("Jmeno", -2, HorizontalAlignment.Left);
            dataGridScore.Columns.Add("Cas", -2, HorizontalAlignment.Left);
            dataGridScore.Columns.Add("PocetKliku", -2, HorizontalAlignment.Left);

            List<Score> scores;

            scores = Program.ScoreDatabase.QueryGet().Result; //vytazeni predeslych vysledku t databaze

            foreach (var score in scores) //vypsani
            {
                ListViewItem viewItem = new ListViewItem(score.ID.ToString());
                viewItem.SubItems.Add(score.Jmeno);
                viewItem.SubItems.Add(score.Cas);
                viewItem.SubItems.Add(score.PocetKliku.ToString());
                dataGridScore.Items.Add(viewItem);
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
