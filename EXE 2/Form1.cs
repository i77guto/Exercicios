namespace EXE_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double cotacao = Convert.ToDouble(txtCotacao.Text);
            double dolares = Convert.ToDouble(txtDolares.Text);
            double reais = dolares * cotacao;
            lblResultado.Text = "O valor em reais é: R$ " + reais.ToString("F2");
        }
    }
}
