namespace WFinicial
{
    partial class FormEx8
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            gbxOperaracao = new GroupBox();
            rdbSoma = new RadioButton();
            rdbSubtracao = new RadioButton();
            rdbMultiplicacao = new RadioButton();
            rdbDivisao = new RadioButton();
            rdbPotenciacao = new RadioButton();
            rdbRadiciacao = new RadioButton();
            btnCalcular = new Button();
            gbxOperaracao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(29, 33);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Número 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(102, 33);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(29, 79);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Número 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(102, 71);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // gbxOperaracao
            // 
            gbxOperaracao.Controls.Add(rdbRadiciacao);
            gbxOperaracao.Controls.Add(rdbSoma);
            gbxOperaracao.Controls.Add(rdbPotenciacao);
            gbxOperaracao.Controls.Add(rdbSubtracao);
            gbxOperaracao.Controls.Add(rdbDivisao);
            gbxOperaracao.Controls.Add(rdbMultiplicacao);
            gbxOperaracao.Location = new Point(240, 32);
            gbxOperaracao.Name = "gbxOperaracao";
            gbxOperaracao.Size = new Size(131, 206);
            gbxOperaracao.TabIndex = 5;
            gbxOperaracao.TabStop = false;
            gbxOperaracao.Text = "Operação";
            // 
            // rdbSoma
            // 
            rdbSoma.AutoSize = true;
            rdbSoma.Location = new Point(6, 39);
            rdbSoma.Name = "rdbSoma";
            rdbSoma.Size = new Size(55, 19);
            rdbSoma.TabIndex = 6;
            rdbSoma.TabStop = true;
            rdbSoma.Text = "Soma";
            rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            rdbSubtracao.AutoSize = true;
            rdbSubtracao.Location = new Point(6, 64);
            rdbSubtracao.Name = "rdbSubtracao";
            rdbSubtracao.Size = new Size(78, 19);
            rdbSubtracao.TabIndex = 7;
            rdbSubtracao.TabStop = true;
            rdbSubtracao.Text = "Subtração";
            rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            rdbMultiplicacao.AutoSize = true;
            rdbMultiplicacao.Location = new Point(6, 91);
            rdbMultiplicacao.Name = "rdbMultiplicacao";
            rdbMultiplicacao.Size = new Size(97, 19);
            rdbMultiplicacao.TabIndex = 8;
            rdbMultiplicacao.TabStop = true;
            rdbMultiplicacao.Text = "Múltiplicação";
            rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            rdbDivisao.AutoSize = true;
            rdbDivisao.Location = new Point(6, 116);
            rdbDivisao.Name = "rdbDivisao";
            rdbDivisao.Size = new Size(63, 19);
            rdbDivisao.TabIndex = 9;
            rdbDivisao.TabStop = true;
            rdbDivisao.Text = "Divisão";
            rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbPotenciacao
            // 
            rdbPotenciacao.AutoSize = true;
            rdbPotenciacao.Location = new Point(6, 141);
            rdbPotenciacao.Name = "rdbPotenciacao";
            rdbPotenciacao.Size = new Size(90, 19);
            rdbPotenciacao.TabIndex = 10;
            rdbPotenciacao.TabStop = true;
            rdbPotenciacao.Text = "Potênciação";
            rdbPotenciacao.UseVisualStyleBackColor = true;
            // 
            // rdbRadiciacao
            // 
            rdbRadiciacao.AutoSize = true;
            rdbRadiciacao.Location = new Point(6, 166);
            rdbRadiciacao.Name = "rdbRadiciacao";
            rdbRadiciacao.Size = new Size(82, 19);
            rdbRadiciacao.TabIndex = 11;
            rdbRadiciacao.TabStop = true;
            rdbRadiciacao.Text = "Radiacição";
            rdbRadiciacao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(106, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(gbxOperaracao);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "FormEx8";
            Text = "FormEx8";
            gbxOperaracao.ResumeLayout(false);
            gbxOperaracao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private GroupBox gbxOperaracao;
        private RadioButton rdbRadiciacao;
        private RadioButton rdbSoma;
        private RadioButton rdbPotenciacao;
        private RadioButton rdbSubtracao;
        private RadioButton rdbDivisao;
        private RadioButton rdbMultiplicacao;
        private Button btnCalcular;
    }
}