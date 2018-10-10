using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_10_02_Calculator_with_forms
{
    public partial class Form1 : Form
    {
        //Declaring variables
        double total = 0, total2 = 0;
        string oper;
        bool flagop = false;
        double entry;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDecimal.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total = 0;
            flagop = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            docalc();
            txtDisplay.Text = total2.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            docalc();
            oper = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            docalc();
            oper = "/";
            flagop = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            docalc();
            oper = "-";
            flagop = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            docalc();
            oper = "+";
            flagop = true;
        }

        private void docalc()
        {
            if (flagop == false)
            {
                total += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                flagop = true;
            }
            if (oper == "+")
            {
                total += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (oper == "-")
            {
                total -= double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (oper == "*")
            {
                total *= double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (oper == "/")
            {
                total /= double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
        }

    }
}
