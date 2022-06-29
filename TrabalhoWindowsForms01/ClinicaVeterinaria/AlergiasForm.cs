namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class AlergiasForm : Form
    {
        private AlergiaServico alergiaServico;

        public AlergiasForm()
        {
            InitializeComponent();

            alergiaServico = new AlergiaServico();

            ListarAlergias();
        }

        private void AdicionarAlergia(string nome, string causa, string codigoTratamento)
        {
            var alergia = new Alergia();
            alergia.Codigo = alergiaServico.ObterUltimoCodigo() + 1;
            alergia.Nome = nome;
            alergia.Causa = causa;
            alergia.CodigoTratamento = codigoTratamento;

            alergiaServico.Cadastrar(alergia);

            LimparCampos();

            ListarAlergias();
        }

        private void EditarAlergia(string nome, string causa, string codigoTratamento)
        {
            var alergia = new Alergia();
            alergia.Nome = nome;
            alergia.Causa = causa;
            alergia.CodigoTratamento = codigoTratamento;

            var linhaSelecionada = dataGridViewAlergias.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            alergia.Codigo = codigo;

            alergiaServico.Editar(alergia);

            LimparCampos();

            ListarAlergias();
        }

        private void ListarAlergias()
        {
            var alergias = alergiaServico.ObterTodos();

            dataGridViewAlergias.Rows.Clear();

            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];

                dataGridViewAlergias.Rows.Add(new object[]
                {
                    alergia.Codigo, alergia.Nome, alergia.Causa, alergia.CodigoTratamento
                });
            }

            dataGridViewAlergias.ClearSelection();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxCausa.Clear();
            maskedTextBoxCodigoTratamento.Clear();

            dataGridViewAlergias.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var causa = textBoxCausa.Text.Trim();
            var codigoTratamento = maskedTextBoxCodigoTratamento.Text.Trim();

            // TODO Validar dados

            if (dataGridViewAlergias.SelectedRows.Count == 0)
            {
                AdicionarAlergia(nome, causa, codigoTratamento);

                return;
            }

            EditarAlergia(nome, causa, codigoTratamento);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlergias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma alergia.");
                return;
            }

            var linhaSelecionada = dataGridViewAlergias.SelectedRows[0];

            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var causa = linhaSelecionada.Cells[2].Value.ToString();
            var codigoTratamento = linhaSelecionada.Cells[3].Value.ToString();

            textBoxNome.Text = nome;
            textBoxCausa.Text = causa;
            maskedTextBoxCodigoTratamento.Text = codigoTratamento;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridViewAlergias.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione uma alergia.");
                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar esse cadastro?", "Aviso", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridViewAlergias.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                alergiaServico.Apagar(codigoSelecionado);

                ListarAlergias();
            }
        }

        private void buttonVoltarParaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlergiasForm_Load(object sender, EventArgs e)
        {
            ListarAlergias();
        }
    }
}