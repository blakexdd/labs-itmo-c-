
namespace TextEditor
{
    partial class Conversion
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
            this.result = new System.Windows.Forms.Label();
            this.Base2 = new System.Windows.Forms.RadioButton();
            this.Base8 = new System.Windows.Forms.RadioButton();
            this.Base16 = new System.Windows.Forms.RadioButton();
            this.Do = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.BaseChoice = new System.Windows.Forms.GroupBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Base10Input = new System.Windows.Forms.TextBox();
            this.BaseChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(135, 213);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(39, 15);
            this.result.TabIndex = 2;
            this.result.Text = "Result";
            // 
            // Base2
            // 
            this.Base2.AutoSize = true;
            this.Base2.Location = new System.Drawing.Point(6, 25);
            this.Base2.Name = "Base2";
            this.Base2.Size = new System.Drawing.Size(31, 19);
            this.Base2.TabIndex = 3;
            this.Base2.TabStop = true;
            this.Base2.Text = "2";
            this.Base2.UseVisualStyleBackColor = true;
            // 
            // Base8
            // 
            this.Base8.AutoSize = true;
            this.Base8.Location = new System.Drawing.Point(6, 50);
            this.Base8.Name = "Base8";
            this.Base8.Size = new System.Drawing.Size(31, 19);
            this.Base8.TabIndex = 4;
            this.Base8.TabStop = true;
            this.Base8.Text = "8";
            this.Base8.UseVisualStyleBackColor = true;
            // 
            // Base16
            // 
            this.Base16.AutoSize = true;
            this.Base16.Location = new System.Drawing.Point(6, 75);
            this.Base16.Name = "Base16";
            this.Base16.Size = new System.Drawing.Size(37, 19);
            this.Base16.TabIndex = 5;
            this.Base16.TabStop = true;
            this.Base16.Text = "16";
            this.Base16.UseVisualStyleBackColor = true;
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(68, 267);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(62, 38);
            this.Do.TabIndex = 6;
            this.Do.Text = "Do";
            this.Do.UseVisualStyleBackColor = true;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(33, 58);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(77, 15);
            this.input.TabIndex = 8;
            this.input.Text = "Value 10 base";
            // 
            // BaseChoice
            // 
            this.BaseChoice.Controls.Add(this.Base16);
            this.BaseChoice.Controls.Add(this.Base8);
            this.BaseChoice.Controls.Add(this.Base2);
            this.BaseChoice.Location = new System.Drawing.Point(87, 96);
            this.BaseChoice.Name = "BaseChoice";
            this.BaseChoice.Size = new System.Drawing.Size(200, 100);
            this.BaseChoice.TabIndex = 9;
            this.BaseChoice.TabStop = false;
            this.BaseChoice.Text = "BaseChoice";
            this.BaseChoice.Enter += new System.EventHandler(this.BaseChoice_Enter);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(183, 265);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(58, 39);
            this.Ok.TabIndex = 10;
            this.Ok.Text = "ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Base10Input
            // 
            this.Base10Input.Location = new System.Drawing.Point(120, 56);
            this.Base10Input.Name = "Base10Input";
            this.Base10Input.Size = new System.Drawing.Size(166, 23);
            this.Base10Input.TabIndex = 11;
            this.Base10Input.TextChanged += new System.EventHandler(this.Base10Input_TextChanged);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Base10Input);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.BaseChoice);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.result);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.BaseChoice.ResumeLayout(false);
            this.BaseChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RadioButton Base2;
        private System.Windows.Forms.RadioButton Base8;
        private System.Windows.Forms.RadioButton Base16;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.GroupBox BaseChoice;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox Base10Input;
    }
}