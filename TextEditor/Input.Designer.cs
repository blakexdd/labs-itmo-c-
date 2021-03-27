
namespace TextEditor
{
    partial class Input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSide = new System.Windows.Forms.TextBox();
            this.CSide = new System.Windows.Forms.TextBox();
            this.Perimeter = new System.Windows.Forms.CheckBox();
            this.Square = new System.Windows.Forms.CheckBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SideA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BSide
            // 
            this.BSide.Location = new System.Drawing.Point(181, 25);
            this.BSide.Name = "BSide";
            this.BSide.Size = new System.Drawing.Size(85, 23);
            this.BSide.TabIndex = 1;
            this.BSide.TextChanged += new System.EventHandler(this.BSide_TextChanged);
            // 
            // CSide
            // 
            this.CSide.Location = new System.Drawing.Point(307, 25);
            this.CSide.Name = "CSide";
            this.CSide.Size = new System.Drawing.Size(85, 23);
            this.CSide.TabIndex = 2;
            this.CSide.TextChanged += new System.EventHandler(this.CSide_TextChanged);
            // 
            // Perimeter
            // 
            this.Perimeter.AutoSize = true;
            this.Perimeter.Location = new System.Drawing.Point(60, 77);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.Size = new System.Drawing.Size(77, 19);
            this.Perimeter.TabIndex = 3;
            this.Perimeter.Text = "Perimeter";
            this.Perimeter.UseVisualStyleBackColor = true;
            this.Perimeter.CheckedChanged += new System.EventHandler(this.Perimeter_CheckedChanged);
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(172, 77);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(62, 19);
            this.Square.TabIndex = 4;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.CheckedChanged += new System.EventHandler(this.Square_CheckedChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(58, 122);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(103, 40);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // SideA
            // 
            this.SideA.Location = new System.Drawing.Point(52, 25);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(85, 23);
            this.SideA.TabIndex = 9;
            this.SideA.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 422);
            this.Controls.Add(this.SideA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Perimeter);
            this.Controls.Add(this.CSide);
            this.Controls.Add(this.BSide);
            this.Name = "Input";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BSide;
        private System.Windows.Forms.TextBox CSide;
        private System.Windows.Forms.CheckBox Perimeter;
        private System.Windows.Forms.CheckBox Square;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SideA;
    }
}