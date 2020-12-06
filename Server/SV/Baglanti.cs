using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SV
{
    public partial class Baglanti : Form
    {
        public string ID = ""; Socket socket;
        public Baglanti(Socket sck, string aydi)
        {
            InitializeComponent();
            ID = aydi;
            socket = sck;
        }
        bool isNotEmpty = false;
        private void button1_Click(object sender, EventArgs e)
        {
            isNotEmpty = textBox1.Text != "" && textBox2.Text != "";
            if (isNotEmpty)
            {
                try
                {
                    Form1.KomutGonder("UPDATE", "[VERI]" + textBox1.Text + "[VERI]" + textBox2.Text + "[VERI]"
                        + numericUpDown1.Value.ToString() + "[VERI][0x09]", socket);
                    Close();
                }
                catch (Exception) { }
            }
        }
    }
}
