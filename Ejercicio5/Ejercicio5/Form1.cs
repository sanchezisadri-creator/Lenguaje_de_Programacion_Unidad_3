namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(maskedTextBox1.Text);
            int Contador = 0;

            for (int i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    Contador = Contador + 1;
                }
            }

            if (Contador == 2)
            {
                MessageBox.Show("El numero es primo");
            }
            else
            {
                MessageBox.Show("El numero no es primo");
            }

        }
    }
}
