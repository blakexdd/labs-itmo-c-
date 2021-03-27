
namespace WordsCount
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUpload = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.WordsCount = new System.Windows.Forms.Button();
            this.LetterCount = new System.Windows.Forms.Button();
            this.textUploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.letter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textUpload
            // 
            this.textUpload.Location = new System.Drawing.Point(77, 56);
            this.textUpload.Name = "textUpload";
            this.textUpload.Size = new System.Drawing.Size(144, 62);
            this.textUpload.TabIndex = 0;
            this.textUpload.Text = "textUpload";
            this.textUpload.UseVisualStyleBackColor = true;
            this.textUpload.Click += new System.EventHandler(this.textUpload_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(397, 53);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(172, 64);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // WordsCount
            // 
            this.WordsCount.Location = new System.Drawing.Point(77, 263);
            this.WordsCount.Name = "WordsCount";
            this.WordsCount.Size = new System.Drawing.Size(149, 86);
            this.WordsCount.TabIndex = 2;
            this.WordsCount.Text = "WordsCount";
            this.WordsCount.UseVisualStyleBackColor = true;
            this.WordsCount.Click += new System.EventHandler(this.WordsCount_Click);
            // 
            // LetterCount
            // 
            this.LetterCount.Location = new System.Drawing.Point(397, 249);
            this.LetterCount.Name = "LetterCount";
            this.LetterCount.Size = new System.Drawing.Size(171, 100);
            this.LetterCount.TabIndex = 3;
            this.LetterCount.Text = "LetterCount";
            this.LetterCount.UseVisualStyleBackColor = true;
            this.LetterCount.Click += new System.EventHandler(this.LetterCount_Click);
            // 
            // textUploadDialog
            // 
            this.textUploadDialog.FileName = "text";
            // 
            // letter
            // 
            this.letter.Location = new System.Drawing.Point(435, 220);
            this.letter.Name = "letter";
            this.letter.Size = new System.Drawing.Size(100, 23);
            this.letter.TabIndex = 4;
            this.letter.TextChanged += new System.EventHandler(this.letter_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.letter);
            this.Controls.Add(this.LetterCount);
            this.Controls.Add(this.WordsCount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textUpload);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button textUpload;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button WordsCount;
        private System.Windows.Forms.Button LetterCount;
        private System.Windows.Forms.OpenFileDialog textUploadDialog;
        private System.Windows.Forms.TextBox letter;
    }
}

