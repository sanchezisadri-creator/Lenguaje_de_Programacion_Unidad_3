namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbDe.Items.Add("Metros");
            cmbDe.Items.Add("Centímetros");
            cmbDe.Items.Add("Pulgadas");

            cmbA.Items.Add("Metros");
            cmbA.Items.Add("Centímetros");
            cmbA.Items.Add("Pulgadas");

            cmbDe.SelectedIndex = 0;
            cmbA.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;

            if (!double.TryParse(txtValor.Text, out valor))
            {
                MessageBox.Show("Ingrese un valor válido");
                return;
            }

            if (cmbDe.SelectedItem == null || cmbA.SelectedItem == null)
            {
                MessageBox.Show("Seleccione ambas unidades");
                return;
            }

            string unidadOrigen = cmbDe.SelectedItem.ToString();
            string unidadDestino = cmbA.SelectedItem.ToString();

            double valorEnMetros = 0;
            double resultado = 0;

            switch (unidadOrigen)
            {
                case "Metros":
                    valorEnMetros = valor;
                    break;
                case "Centímetros":
                    valorEnMetros = valor / 100;
                    break;
                case "Pulgadas":
                    valorEnMetros = valor * 0.0254;
                    break;
            }

            switch (unidadDestino)
            {
                case "Metros":
                    resultado = valorEnMetros;
                    break;
                case "Centímetros":
                    resultado = valorEnMetros * 100;
                    break;
                case "Pulgadas":
                    resultado = valorEnMetros / 0.0254;
                    break;
            }

            lblResultado.Text = valor + " " + unidadOrigen +
                                " = " + resultado.ToString("F4") +
                                " " + unidadDestino;
        }
    }
}

