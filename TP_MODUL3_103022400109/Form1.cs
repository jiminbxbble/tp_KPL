using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400109
{
    public partial class Form1 : Form
    {
        int total = 0;
        bool isPlusClicked = false;

        public Form1()
        {
            InitializeComponent();
            lbloutput.Text = "0";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lbloutput.Text == "0" || isPlusClicked)
            {
                lbloutput.Text = "";
                isPlusClicked = false;
            }

            lbloutput.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            total += int.Parse(lbloutput.Text);
            isPlusClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            total += int.Parse(lbloutput.Text);
            lbloutput.Text = total.ToString();
            total = 0;
            isPlusClicked = true;
        }
    }
}