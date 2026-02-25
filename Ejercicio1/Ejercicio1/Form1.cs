namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            lstTabla.Items.Clear();

            
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Por favor ingrese un número");
                return;
            }

            
            int numero = Convert.ToInt32(txtNumero.Text);

            
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                lstTabla.Items.Add(numero + " x " + i + " = " + resultado);
            }
        }
    }
}
