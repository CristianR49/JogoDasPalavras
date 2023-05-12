namespace JogoDasPalavras
{
    public partial class JogoPalavrasTela : Form
    {
        public string palpite;
        private JogoPalavras jogoPalavras;
        List<Label> espacosLetrasDesorganizado;
        List<Label> espacosLetras;
        string palavraMisteriosa;
        int letrasPorPalavra = 5;
        int espacoAtual = 0;
        int letraMisteriosaAtual = 0;
        int acertosPorLinha = 0;
        public JogoPalavrasTela()
        {
            InitializeComponent();

            jogoPalavras = new JogoPalavras();

            InstanciarEOrganizarListEspacosLetras();

            palavraMisteriosa = jogoPalavras.ObterPalavraSecreta();

            RegistrarEventos();
        }

        private void InstanciarEOrganizarListEspacosLetras()
        {
            espacosLetrasDesorganizado = new List<Label>();
            foreach (Label l in tlpEspacosLetras.Controls)
            {
                espacosLetrasDesorganizado.Add(l);
            }

            espacosLetras = new List<Label>();
            espacosLetras = jogoPalavras.OrganizarListEspacosLetras(espacosLetrasDesorganizado, espacosLetras);
        }

        public void RegistrarEventos()
        {
            foreach (Button b in tableLayoutPanel1.Controls)
            {
                b.Click += DarPalpite;
            }
        }

        private void DarPalpite(object? sender, EventArgs e)
        {
            Button botao = (Button)sender;

            string palpite = botao.Text;

            jogoPalavras.InserirPalpite(palpite, espacosLetras);
            ValidarLetras();

        }

        private void ValidarLetras()
        {

            VerificarAcertoAmarelo();

            VerificarAcertoVerde();

            espacoAtual++;
            letraMisteriosaAtual++;


            if (acertosPorLinha == 5)
            {
                AnunciarVitoria();
            }
            else if (espacoAtual == 25)
            {
                AnunciarDerrota();
            }

            if (letraMisteriosaAtual == 5)
            {
                letraMisteriosaAtual = 0;
                acertosPorLinha = 0;
            }
        }

        private void AnunciarDerrota()
        {
            tableLayoutPanel1.Enabled = false;
            MessageBox.Show($"Que pena, você perdeu! A palavra era\"{palavraMisteriosa}\"");
        }

        private void AnunciarVitoria()
        {
            tableLayoutPanel1.Enabled = false;
            MessageBox.Show($"Parabéns, você acertou! A palavra era\"{palavraMisteriosa}\"");
        }

        private void Reiniciar()
        {
            palavraMisteriosa = jogoPalavras.ObterPalavraSecreta();
            letrasPorPalavra = 5;
            espacoAtual = 0;
            letraMisteriosaAtual = 0;
            acertosPorLinha = 0;
            foreach (Label l in espacosLetras)
            {
                l.Text = "";
                l.BackColor = Color.White;
            }
            tableLayoutPanel1.Enabled = true;
            jogoPalavras.ResetarVariaveisJogoPalavras();
        }

        private void VerificarAcertoVerde()
        {
            if (Convert.ToString(palavraMisteriosa[letraMisteriosaAtual]).ToUpper() == espacosLetras[espacoAtual].Text)
            {
                espacosLetras[espacoAtual].BackColor = Color.Green;
                acertosPorLinha++;
            }
        }

        private void VerificarAcertoAmarelo()
        {
            foreach (char c in palavraMisteriosa)
            {
                if (Convert.ToString(c).ToUpper() == espacosLetras[espacoAtual].Text)
                {
                    espacosLetras[espacoAtual].BackColor = Color.Yellow;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }
    }
}