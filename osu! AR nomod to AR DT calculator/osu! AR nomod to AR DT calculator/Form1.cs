using System;
using System.Windows.Forms;

namespace osu__AR_nomod_to_AR_DT_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal AR;
            AR = numericUpDown1.Value;

            AR = (AR * 2 + 13) / 3; // calculating AR into DT
            
            label2.Text = "AR with DT: " + String.Format("{0:.#}", AR); // show AR with only 1 decimal digit
        }
    }
}
