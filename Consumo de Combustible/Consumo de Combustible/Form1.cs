namespace Consumo_de_Combustible
{
    public partial class Form1 : Form


    {

        private double distanciaValue = 0;
        private double rendimientoValue = 0;
        private double gas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void distancia_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(distancia.Text, out distanciaValue);
        }

        private void rendimiento_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(rendimiento.Text, out rendimientoValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gas = distanciaValue / rendimientoValue;

          
            Gas.Text = gas.ToString();
        }

        private void Gas_Click(object sender, EventArgs e)
        {

        }
    }
}
