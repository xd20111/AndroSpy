using System;
using System.Windows.Forms;

namespace SV
{
    public partial class Port : Form
    {
        public Port()
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
        }
        //string marka = "samsung"; string api = "28";  //I have wanted to realize logics. so I have wanted to see that it works correct or not.
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.port_no = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string lbl = label2.Text;
            lbl = lbl.Substring(lbl.Length - 1) + lbl.Substring(0, lbl.Length - 1);
            label2.Text = lbl;
        }
    }
}
