using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_22._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRisultato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            
            txtRisultato.Text = (a + b).ToString();
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            if (a > b)
            {
                txtRisultato.Text = (a - b).ToString();
            }
            else if(a < b)
            {
                txtRisultato.Text = (b - a).ToString();
            }
            else 
            { 
                txtRisultato.Text = "0"; 
            }
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            txtRisultato.Text = (a * b).ToString();
        }

        private void btnDiviso_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            if (b == 0)
            {
                MessageBox.Show("Al denominatore non può starci uno zero");
            }

            txtRisultato.Text = (a / b).ToString();
        }
    }
}
