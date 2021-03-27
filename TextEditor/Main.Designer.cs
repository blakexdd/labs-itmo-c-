
namespace TextEditor
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
            this.input = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(64, 126);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(128, 84);
            this.input.TabIndex = 0;
            this.input.Text = "input";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(483, 126);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(154, 84);
            this.convert.TabIndex = 2;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(64, 392);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(145, 55);
            this.About.TabIndex = 3;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(483, 392);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(154, 54);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(280, 129);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(125, 80);
            this.Calc.TabIndex = 5;
            this.Calc.Text = "Calc";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 519);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.input);
            this.Name = "Main";
            this.Text = "Гололобов В.В. K3220 Вариант2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button input;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Calc;
    }
}

