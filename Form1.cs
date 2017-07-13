using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double dblTotal, dblSpeed, dblRate;
            int intRate = 0;
            dblSpeed = Convert.ToDouble(txtSpeed.Text);
            dblRate = Convert.ToDouble(txtHours.Text);
            while (intRate < dblRate)
            {
                dblTotal = dblSpeed * intRate;
                lstOut.Items.Add(dblTotal);
                intRate++;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = "";
            txtSpeed.Text = "";
            lstOut.Items.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
