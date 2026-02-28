namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int inicio, fin;

            lstPrimos.Items.Clear();

            if (!int.TryParse(txtInicio.Text, out inicio) ||
                !int.TryParse(txtFin.Text, out fin))
            {
                MessageBox.Show("Digite valores numéricos válidos");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El número Inicio no puede ser mayor que Fin");
                return;
            }

            for (int numero = inicio; numero <= fin; numero++)
            {
                if (EsPrimo(numero))
                {
                    lstPrimos.Items.Add(numero);
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
