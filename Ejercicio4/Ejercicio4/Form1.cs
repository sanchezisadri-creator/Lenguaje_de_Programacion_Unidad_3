namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", "");

            string invertida = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                invertida += palabra[i];
            }

            if (palabra == invertida)
            {
                MessageBox.Show("La palabra es PALÍNDROMA");
            }
            else
            {
                MessageBox.Show("La palabra NO es palíndroma");
            }
        }
    }
}
