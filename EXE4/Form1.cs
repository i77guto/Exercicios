namespace EXE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
           
            lstTabuada.Items.Clear();

           
            int numero = Convert.ToInt32(txtNumero.Text);

           
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;

               
                lstTabuada.Items.Add(numero + " x " + i + " = " + resultado);
            }
        }
    }
    }

