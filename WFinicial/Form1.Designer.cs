namespace WFinicial
{
    partial class Form1
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
            lblNota1 = new Label();
            txtnota1 = new TextBox();
            btnCalcular = new Button();
            lblNota2 = new Label();
            txtnota2 = new TextBox();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(45, 15);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(43, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "nota: 1";
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(126, 12);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(126, 77);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Média";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(45, 39);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(43, 15);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "nota: 2";
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(126, 39);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnota2);
            Controls.Add(lblNota2);
            Controls.Add(btnCalcular);
            Controls.Add(txtnota1);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Calcular Media das notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private TextBox txtnota1;
        private Button btnCalcular;
        private Label lblNota2;
        private TextBox txtnota2;
    }
}
