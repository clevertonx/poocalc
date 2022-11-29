namespace Calc_teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculadora calculadora= new calculadora();

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn0.Text;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + virgula.Text;
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            calculadora.Setelemento2(double.Parse(display.Text));
            display.Text = calculadora.executaroperacao().ToString();
        }

        private void adiçao_Click(object sender, EventArgs e)
        {
            calculadora.Setelemento1(double.Parse(display.Text));
            display.Text = "";
            calculadora.Setoperacao("+");
            
        }

        private void menos_Click(object sender, EventArgs e)
        {
            calculadora.Setelemento1(double.Parse(display.Text));
            display.Text = "";
            calculadora.Setoperacao("-");
        }

        private void multi_Click(object sender, EventArgs e)
        {
            calculadora.Setelemento1(double.Parse(display.Text));
            display.Text = "";
            calculadora.Setoperacao("*");
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            calculadora.Setelemento1(double.Parse(display.Text));
            display.Text = "";
            calculadora.Setoperacao("/");
        }
    }
}