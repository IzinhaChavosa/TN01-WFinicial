namespace WFinicial
{
    partial class FormEx6
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
            btnResultado = new Button();
            lblNome = new Label();
            lblValorHora = new Label();
            txtNome = new TextBox();
            txtValorHora = new TextBox();
            lblquantHoras = new Label();
            txtQuantHoras = new TextBox();
            SuspendLayout();
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(107, 114);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(75, 23);
            btnResultado.TabIndex = 0;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(26, 50);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(76, 15);
            lblValorHora.TabIndex = 2;
            lblValorHora.Text = "Valor da hora";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(168, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(168, 42);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 4;
            // 
            // lblquantHoras
            // 
            lblquantHoras.AutoSize = true;
            lblquantHoras.Location = new Point(26, 82);
            lblquantHoras.Name = "lblquantHoras";
            lblquantHoras.Size = new Size(120, 15);
            lblquantHoras.TabIndex = 5;
            lblquantHoras.Text = "Quantidade De Horas";
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(168, 71);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(100, 23);
            txtQuantHoras.TabIndex = 6;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 274);
            Controls.Add(txtQuantHoras);
            Controls.Add(lblquantHoras);
            Controls.Add(txtValorHora);
            Controls.Add(txtNome);
            Controls.Add(lblValorHora);
            Controls.Add(lblNome);
            Controls.Add(btnResultado);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResultado;
        private Label lblNome;
        private Label lblValorHora;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private Label lblquantHoras;
        private TextBox txtQuantHoras;
    }
}