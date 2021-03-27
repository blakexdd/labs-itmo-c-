using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCount
{
    public partial class Main : Form
    {
        private string fileText;
        public Main()
        {
            InitializeComponent();
            textUploadDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void textUpload_Click(object sender, EventArgs e)
        {
            if (textUploadDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = textUploadDialog.FileName;
            this.fileText = System.IO.File.ReadAllText(filename);
   
            MessageBox.Show("Файл открыт");
        }

        private void LetterCount_Click(object sender, EventArgs e)
        {
            string inputLetter = this.letter.Text;
            int letterCount = 0;
            string errors = "";

            if (this.fileText == null)
            {
                errors += "No input text\n";
            }

            if (inputLetter == null)
            {
                errors += "Not letter\n";
            }

            if (inputLetter.Length != 1 || !char.IsLetter(inputLetter[0]))
            {
                errors += inputLetter + " is not letter\n";
            }

            if (errors != "")
            {
                MessageBox.Show(errors);
                return;
            }

            foreach (var c in this.fileText.ToLower())
            {
                if (c == inputLetter[0])
                {
                    letterCount++;
                }
            }

            MessageBox.Show("Found " + letterCount + " occurances of letter: " + inputLetter[0]);
        }

        private void WordsCount_Click(object sender, EventArgs e)
        {
            if (this.fileText == null)
            {
                MessageBox.Show("Not file text");
                return;
            }

            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int wordsCount = this.fileText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            MessageBox.Show("Words in text: " + wordsCount);
        }

        private void letter_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
