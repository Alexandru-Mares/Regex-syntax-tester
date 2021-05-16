using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regex_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(txtPattern.Text);
            bool result = regex.IsMatch(txtText.Text);
            lblResult.Text = result.ToString();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            txtPattern.Text = "^[a-zA-Z0-9\\._-]{5,25}@[a-z]{1,12}\\.[a-z]{2,5}";
            txtText.Text = "mares.alexandru97@gmail.com";
        }

        private void btn_email_exclusion_Click(object sender, EventArgs e)
        {
            txtPattern.Text = "^[a-zA-Z0-9\\._-]{5,25}@[a-z]{1,12}\\.[^(ro|gov)]";
            txtText.Text = "mares.alexandru97@gmail.com";
        }

        private void btn_phone_Click(object sender, EventArgs e)
        {
            txtPattern.Text = "\\+?[0-9]{9,15}";
            txtText.Text = "+40735838191";
        }
    }
}
