using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Horsburgh2.hwk
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if(val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Multiply Results  " + (val1 * val2).ToString();
            }
            lblResult.Visible = true;




        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double val1, val2;

            val1 = GetFirstValue();
            val2 = GetSecondValue();

            if (val1 > 0 && val2 > 0)
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Add Results  " + (val1 + val2).ToString();
            }
            lblResult.Visible = true;

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtValue1.Text = "";
            txtValue2.Text = "";
            lblResult.Visible = false;
            txtValue1.Focus();

        }

        public double GetFirstValue()
        {
            double val1;

            while (double.TryParse(txtValue1.Text, out val1) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                lblResult.Visible = true;
                txtValue1.Text = "0";
                txtValue1.Focus();
            }
            return val1;
        }

        public double GetSecondValue()
        {
            double val2;

            while (double.TryParse(txtValue1.Text, out val2) == false)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and > 0.";
                lblResult.Visible = true;
                txtValue2.Text = "0";
                txtValue2.Focus();
            }
            return val2;
        }
    }
}
