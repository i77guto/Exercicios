namespace EXE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(txtDistancia.Text);
            double preco;
           

           
            if (distancia <= 200)
            {
              
                preco = distancia * 0.50;
            }
            else
            {
              
                preco = distancia * 0.45;
            }

           
            lblResultado.Text = "Preço da passagem: R$ " + preco.ToString("F2");
        }

    }
    }

