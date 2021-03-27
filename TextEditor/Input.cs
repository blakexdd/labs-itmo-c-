using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Input : Form
    {
        private string sideA;
        private string sideB;
        private string sideC;
        private Boolean calcSquare = false;
        private Boolean calcPerimeter = false;
        private Boolean allowProcessing = false;

        public Input()
        {
            InitializeComponent();
        }

        private void SideA_TextChanged(object sender, EventArgs e)
        {
            this.sideA = this.SideA.Text;
        }

        private void BSide_TextChanged(object sender, EventArgs e)
        {
            this.sideB = this.BSide.Text;
        }

        private void CSide_TextChanged(object sender, EventArgs e)
        {
            this.sideC = this.CSide.Text;
        }

        private void Perimeter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            this.calcPerimeter = checkBox.Checked;
        }

        private void Square_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            this.calcSquare = checkBox.Checked;
        }

        public Boolean getAllowProcessing()
        {
            return this.allowProcessing;
        }
        public Boolean getCalcPerimeter()
        {
            return this.calcPerimeter;
        }
        public Boolean getCalcSquare()
        {
            return this.calcSquare;
        }
        public double getSideA()
        {
            return Double.Parse(this.sideA);
        }
        public double getSideB()
        {
            return Double.Parse(this.sideB);
        }
        public double getSideC()
        {
            return Double.Parse(this.sideC);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string errors = "";
            double sideADouble = 0;
            double sideBDouble = 0;
            double sideCDouble = 0;
            try
            {
                sideADouble = Double.Parse(this.sideA);
            }
            catch
            {
                errors += "Side a is in invalid format\n";
            }
            try
            {
                sideBDouble = Double.Parse(this.sideB);
            }
            catch
            {
                errors += "Side b is in invalid format\n";
            }
            try
            {
                sideCDouble = Double.Parse(this.sideC);
            }
            catch
            {
                errors += "Side c is in invalid format\n";
            }

            if (!(sideADouble > 0 && sideBDouble > 0 && sideCDouble > 0 &&
                !(sideADouble + sideBDouble <= sideCDouble 
                || sideADouble + sideCDouble <= sideBDouble 
                || sideBDouble + sideCDouble <= sideADouble)))
            {
                errors += "Triangle with givven sides does not exist";
            }

            if (!(this.calcPerimeter || this.calcSquare))
            {
                errors += "Must choose at least one option\n";
            }

            if (errors != "")
            {
                allowProcessing = false;
                MessageBox.Show(errors);
            }
            else
            {
                allowProcessing = true;
                MessageBox.Show("Correct input");
            }
        }
    }
}
