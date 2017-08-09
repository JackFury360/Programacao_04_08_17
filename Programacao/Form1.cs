using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Título";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("\n");
            textBox2.AppendText("Apertei porra" );

            checkBox1.Enabled = !checkBox1.Enabled;

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.AppendText("\n");
                textBox2.AppendText("Shazan carai");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value == 5)
            {
                textBox2.AppendText("\n");
                textBox2.AppendText("Só vai");
            }

            label1.Text = trackBar1.Value.ToString();

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
