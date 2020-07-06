using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace criandoInterfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string cidade = comboBox1.SelectedItem.ToString();

            string tipo;
            if(radioButton1.Checked == true)
            {
                tipo = "vendedor";
            }
            else
            {
                tipo = "cliente";
            }

            MessageBox.Show("BEM VINDO AO MEU SISTEMA! " + nome + " da cidade " + cidade + " você é um " + tipo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
