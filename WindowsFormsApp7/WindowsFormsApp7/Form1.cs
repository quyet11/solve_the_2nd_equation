using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        private void txtresult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //convert from string to int
            int a = Convert.ToInt32(lbldisplayA.Text.ToString().Trim());
            int b = Convert.ToInt32(lbldisplayB.Text.ToString().Trim());
            int c = Convert.ToInt32(lbldisplayC.Text.ToString().Trim());
            //solution of equation
            double x1;
            double x2;
            //Delta's formula
            double delta = b * b - 4 * a * c;
            //check delta conditional
            if (delta < 0)
            {
                //Display
                lbldisplayResult.Text = $@"phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                int x = -b / 2 * a;//x1 = x2 = -b/(2*a)
                                   //Display
                lbldisplayResult.Text = $@"phuong trinh co nghiem kep {x.ToString()}";
            }
            else
            {
                double result = Math.Sqrt(delta);
                x1 = (double)(result - b) / (2 * a);
                x2 = (double)(-(b) - result) / (2 * a);
                //Display
                lbldisplayResult.Text = $@"phuong trinh co 2 nghiem phan biet
 x1 = {x1.ToString()}
 x2 = {x2.ToString()}";
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            //delete all textbox
            lbldisplayA.Clear();
            lbldisplayB.Clear();
            lbldisplayResult.Clear();
            lbldisplayC.Clear();
        }

    }
}
