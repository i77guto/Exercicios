namespace EXE_2
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
            label1 = new Label();
            label2 = new Label();
            lblResultado = new Label();
            txtDolares = new TextBox();
            txtCotacao = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do dólar (R$):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 1;
            label2.Text = "“Quantidade em dólares (US$):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(201, 76);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(187, 38);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 3;
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(187, 9);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 4;
            txtCotacao.TextChanged += textBox2_TextChanged;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(12, 76);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConverter);
            Controls.Add(txtCotacao);
            Controls.Add(txtDolares);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResultado;
        private TextBox txtDolares;
        private TextBox txtCotacao;
        private Button btnConverter;
    }
}
