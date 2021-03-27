using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Conversion : Form
    {
        private string inputNumber;
        private string baseChoice;

        public Conversion()
        {
            InitializeComponent();
        }

        private void Base10Input_TextChanged(object sender, EventArgs e)
        {
            this.inputNumber = this.Base10Input.Text;
        }

        private void BaseChoice_Enter(object sender, EventArgs e)
        {
        }

        private void Do_Click(object sender, EventArgs e)
        {
            string errors = "";
            string result = "";
            int number = 0;

            try
            {
                number = int.Parse(this.inputNumber);
            }
            catch 
            {
                errors += "Must input integer, got: " + this.inputNumber + "\n";
            }

            if (this.Base2.Checked)
            {
                result = Convert.ToString(number, 2);
                this.baseChoice = this.Base2.Text;
            }
            else if (this.Base8.Checked)
            {
                result = Convert.ToString(number, 8);
                this.baseChoice = this.Base8.Text;
            }
            else if (this.Base16.Checked)
            {
                result = Convert.ToString(number, 16);
                this.baseChoice = this.Base16.Text;
            }
            else
            {
                errors += "Must provide base to convert\n";
            }

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }

            MessageBox.Show("Number: " + this.inputNumber + " is " + result + " int base " + this.baseChoice);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
