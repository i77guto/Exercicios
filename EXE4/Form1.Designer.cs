namespace EXE4
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
            Numero = new Label();
            txtNumero = new TextBox();
            btnGerar = new Button();
            lstTabuada = new ListBox();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(12, 9);
            Numero.Name = "Numero";
            Numero.Size = new Size(54, 15);
            Numero.TabIndex = 0;
            Numero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(92, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(2, 45);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 15;
            lstTabuada.Location = new Point(2, 74);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(265, 139);
            lstTabuada.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTabuada);
            Controls.Add(btnGerar);
            Controls.Add(txtNumero);
            Controls.Add(Numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Numero;
        private TextBox txtNumero;
        private Button btnGerar;
        private ListBox lstTabuada;
    }
}
