using System;
using System.Windows.Forms;

namespace Point_scoring_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //here we could have the team/ invdividuals appear when the arrow is hit (the example being team 1 and team 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Score saved!");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            // this closes the whole software ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //what happens at every state, where the form is loaded ;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }// this is a dropdown which allows the judges to pick a score (currently from 1 to 10);

    }
}

