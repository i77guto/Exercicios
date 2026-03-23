namespace Exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
          double celsius = Convert.ToDouble(txtCelsius.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            lblResultado.Text = "O resultado é: " + fahrenheit + " °F";


        }
    }
}
