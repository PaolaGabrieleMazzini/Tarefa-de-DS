namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();
            string usuario = "Paola";
            string senha = "Paola2209@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                lsbMostra.Items.Add("Acesso Autorizado!");
            }
            else
            {
                lsbMostra.Items.Add("Acesso Negado!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            
            lsbMostra.Items.Clear();
            int[] numeros = { 15, 42, 8, 73, 21 };

            int maior = numeros[0];
            int menor = numeros[0];

            int i = 0;

            while (i < numeros.Length)
            {
                lsbMostra.Items.Add(
         numeros[i] +
         " -> Antecessor: " + (numeros[i] - 1) +
         " | Sucessor: " + (numeros[i] + 1));

                i++;
            }


        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
        
            lsbMostra.Items.Clear();

            int numero = 1;

            do
            {
                lsbMostra.Items.Add(
                    "√" + numero + " = " +
                    Math.Sqrt(numero).ToString("F2"));

                numero++;
            }
            while (numero <= 400);
        
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            for (int numero = 2; numero <= 100; numero++)
            {
                bool primo = true;

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                    {
                        lsbMostra.Items.Add(numero);
                    }
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
        
            lsbMostra.Items.Clear();
            int[] numeros = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = i + 1;
            }

            foreach (int numero in numeros)
            {
                lsbMostra.Items.Add(numero + "² = " + (numero * numero));
            }
        }


        private void btnBreak_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;
                if (cont == 2)
                {
                    break;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;

                if (cont == 2)
                {
                    continue;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
