using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            {
              double R1=double.Parse(textBox1.Text);
                double R2=double.Parse(textBox2.Text  );
                double R3= double.Parse(textBox3.Text);

                double RT = R1 + R2 + R3;

                label7.Text = "RT= " +RT;

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double R1 = double.Parse(textBox4.Text);
            double R2 = double.Parse(textBox5.Text);
            double R3 = double.Parse(textBox6.Text);
            double RT = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3);
            label8.Text = "RT= " + RT;
        }
    }
}
