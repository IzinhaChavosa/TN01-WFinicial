﻿namespace WFinicial
{
    partial class FormEx3
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
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            btnMaior = new Button();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(101, 59);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(29, 67);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Número 1";
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(108, 118);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(93, 23);
            btnMaior.TabIndex = 2;
            btnMaior.Text = "Mostrar Maior";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(29, 97);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 3;
            lblNum2.Text = "Número 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(101, 89);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 4;
            // 
            // FormEx3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(btnMaior);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Name = "FormEx3";
            Tag = "FormEx3";
            Text = "FormEx3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblNum1;
        private Button btnMaior;
        private Label lblNum2;
        private TextBox txtNum2;
    }
}