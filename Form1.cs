using System;
using System.Windows.Forms;

namespace Point_scoring_system
{
    public partial class Points : Form
    {
        public Points()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //here we could have the team/ invdividuals appear when the arrow is hit

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //how many points

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
            // this closes the whole software 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
