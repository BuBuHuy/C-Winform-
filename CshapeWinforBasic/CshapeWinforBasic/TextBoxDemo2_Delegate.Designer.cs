﻿namespace CshapeWinforBasic
{
    partial class Form2
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
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(24, 36);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(185, 20);
            this.txt2.TabIndex = 0;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt2);
            this.Name = "Form2";
            this.Text = "From2";
            this.Load += new System.EventHandler(this.f2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2;
    }
}