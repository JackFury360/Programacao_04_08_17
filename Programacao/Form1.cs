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
        public int max;
        public int min;
        public Random rnd = new Random();
        public int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Av1 - 2003 : Gabriel Figueiredo, Gilherme de Lima e Julia dos Santos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = rnd.Next(min, max + 1);
            textBox2.AppendText("\n");
            textBox2.AppendText("Apertei o botão e o resultado foi: " + result);
            label2.Text = "Valor Random: " + result;
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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Valor MAX: " + trackBar1.Value.ToString();
            max = trackBar1.Value;
           
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

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

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            label3.Text = "Valor MIN: " + trackBar2.Value.ToString();
            min = trackBar2.Value;
        }
    }
}
