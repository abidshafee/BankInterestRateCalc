using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterestRateCalc
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

        private void bankNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        double I, P, n, x, y;

        public void inputFunc()
        {
            n = Convert.ToDouble(timeInYeartextBox.Text);
            P = Convert.ToDouble(totalBalanceTextBox.Text);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (bankNameComboBox.SelectedIndex==1)
            {
                inputFunc();
                y = 1.08;
                x = Math.Pow(y, n); 
                I = P*x - P;
                resultBox.Text = Convert.ToString(I);
            }
            if (bankNameComboBox.SelectedIndex == 2)
            {
                inputFunc();
                y = 1.05;
                x = Math.Pow(y, n);
                I = P * x - P;
                //I = 5*P *(n/100);
                resultBox.Text = Convert.ToString(I);
            }
            if (bankNameComboBox.SelectedIndex == 3)
            {
                inputFunc();
                I = 7*P*(n/100);
                resultBox.Text = Convert.ToString(I);
            }
            if (bankNameComboBox.SelectedIndex == 4)
            {
                inputFunc();
                I = 7*P*(n / 100);
                resultBox.Text = Convert.ToString(I);
            }
        }
    }
}
