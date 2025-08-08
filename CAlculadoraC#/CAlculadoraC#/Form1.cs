namespace CAlculadoraC_
{
    public partial class Form1 : Form
    {
        string numero = "0";
        int signo = 0;
        float Resul = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            numero = "1";
            lblOperacion.Text += numero;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = "2";
            lblOperacion.Text += numero;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero = "3";
            lblOperacion.Text += numero;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero = "4";
            lblOperacion.Text += numero;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            numero = "5";
            lblOperacion.Text += numero;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            numero = "6";
            lblOperacion.Text += numero;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero = "7";
            lblOperacion.Text += numero;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero = "8";
            lblOperacion.Text += numero;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero = "9";
            lblOperacion.Text += numero;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numero = "0";
            lblOperacion.Text += numero;
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            signo = 0;
            lblOperacion.Text = "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            signo = 1;
            lblOperacion.Text = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            signo = 2;
            lblOperacion.Text="/";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            signo = 3;
            lblOperacion.Text+="X";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            int numeroOp = Convert.ToInt32(numero);
            

            switch (signo)
            {
                case 0:
                    Resul = (numeroOp + numeroOp);
                    calculador.Text = Convert.ToString(Resul);
                    break;
                case 1:
                    Resul = (numeroOp - numeroOp);
                    calculador.Text = Convert.ToString(Resul);
                    break;
                case 2:
                    Resul= (numeroOp / numeroOp);
                    calculador.Text= Convert.ToString(Resul);
                    break;
                case 3:
                    Resul=(numeroOp * numeroOp);
                    calculador.Text=(Convert.ToString(Resul));
                    break;
            }




        }

        private void lblOperacion_Click(object sender, EventArgs e)
        {



        }

        private void calculador_Click(object sender, EventArgs e)
        {

        }
    }
}
