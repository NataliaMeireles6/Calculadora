using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double n1, n2, resultado;
        const int SOMA = 1;
        const int SUB = 2;
        const int MULT = 3;
        const int DIV = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SOMA);
            }
        }

        public Boolean ValidaValor(string vlr)
        {
            Double x;
            if (String.IsNullOrEmpty(vlr)
            || String.IsNullOrWhiteSpace(vlr)
            || Double.TryParse(vlr, out x) == false)
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(SUB);
            }

        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(MULT);
            }

        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {
            if (ValidaValor(nro1.Text) && ValidaValor(nro2.Text))
            {
                Calcula(DIV);

            }
        }
        private void Calcula(int ope)
        {
            n1 = Double.Parse(nro1.Text);
            n2 = Double.Parse(nro2.Text);
            String resposta = String.Empty;
            switch (ope)
            {
                case 1:
                    resultado = n1 + n2;
                    resposta = resultado.ToString();
                    break;
                 case 2:
                    resultado = n1 - n2;
                    resposta = resultado.ToString();
                    break;
                case 3:
                    resultado = n1 * n2;
                    resposta = resultado.ToString();
                    break;
                case 4:
                    if (n2 == 0)
                        resposta = ("Não existe divisão por Zero");
                    else

                    {
                        resultado = n1 / n2;
                        resposta = resultado.ToString();
                    }
                    break;
            }
            Mensagem(resposta);
        }
        private void Mensagem(String txt)
        {
            lblResultado.Text = txt;
        }
    }

}







