using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Main : Form
    {
        private Input inputForm;
        public Main()
        {
            InitializeComponent();
            Text = "Гололобов В.В. K3220 Вариант 1";
            this.BackColor = Color.Aquamarine;
            this.Width = 800;
            this.Height = 500;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void input_Click(object sender, EventArgs e)
        {
            this.inputForm = new Input();
            this.inputForm.Show();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (this.inputForm == null)
            {
                MessageBox.Show("Provide input data first");
                return;
            }

            if (this.inputForm.getAllowProcessing())
            {
                string result = "";
                double a = this.inputForm.getSideA();
                double b = this.inputForm.getSideB();
                double c = this.inputForm.getSideC();

                if (this.inputForm.getCalcPerimeter())
                {
                    result += "Perimeter of triangle is: " + this.Perimetr(a, b, c) + "\n";
                }

                if (this.inputForm.getCalcSquare())
                {
                    result += "Square of triangle is: " + this.Square(a, b, c) + "\n";
                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Check data in input. Something is wrong");
            }
        }
        public double Perimetr(double a, double b, double c)
        {
            return a + b + c;   
        }
        public double Square(double a, double b, double c)
        {
            double P = a + b + c;
            double p = P / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Conversion conversion = new Conversion();
            conversion.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App developed by Vladimir Gololobov VG6");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }
    }
}
