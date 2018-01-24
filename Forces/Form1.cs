using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double FORCE = Convert.ToDouble(textBox1.Text);
            double ANGLE = Convert.ToDouble(textBox2.Text);
            double fx = FORCE * cos(ANGLE);
            double fy = FORCE * sin(ANGLE);
            MessageBox.Show("fx =" + fx);
            MessageBox.Show("fy =" + fy);
        }
        
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

       
    }
}
