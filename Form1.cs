//humberto gonzales,Module 6, Step 2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FallingDistance(double time)
        {
            double distance = 0.5 * 9.8 * Math.Pow(time, 2.0);
            return distance;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double distance,time;


            if (double.TryParse(txtNumber.Text, out time))
            {
                distance = FallingDistance(time);

                lblSum.Text = distance.ToString("n1");
            }
            else
            {
                MessageBox.Show("Please enter a numerical value");
            }          
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
