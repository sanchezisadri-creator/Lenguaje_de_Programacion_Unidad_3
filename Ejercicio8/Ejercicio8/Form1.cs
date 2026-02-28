namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text.Trim();

            if (string.IsNullOrEmpty(oracion))
            {
                lblResultado.Text = "Cantidad de palabras: 0";
                return;
            }

            string[] palabras = oracion.Split(new char[] { ' ' },
                                               StringSplitOptions.RemoveEmptyEntries);

            int cantidad = palabras.Length;

            lblResultado.Text = "Cantidad de palabras: " + cantidad;
        }
    }
}
