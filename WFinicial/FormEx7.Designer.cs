namespace WFinicial
{
    partial class FormEx7
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
            btnCarregar = new Button();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(138, 133);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(75, 23);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(113, 56);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 1;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(54, 59);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(50, 15);
            lblNomeProduto.TabIndex = 2;
            lblNomeProduto.Text = "Produto";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(113, 89);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 3;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(54, 92);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(btnCarregar);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarregar;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private TextBox txtValor;
        private Label lblValor;
    }
}