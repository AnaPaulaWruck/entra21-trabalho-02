namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class VeterinarioForm : Form
    {
        private VeterinarioServico veterinarioServico;
        public VeterinarioForm()
        {
            InitializeComponent();

            veterinarioServico = new VeterinarioServico();

            ListarVeterinarios();

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeVeterinario = textBoxNomeCompleto.Text.Trim();
            var especializacao = textBoxEspecializacao.Text.Trim();
            var crmv = Convert.ToInt32(textBoxCrmv.Text.Trim());

            var dadosValidos = ValidarDados(nomeVeterinario, especializacao, crmv);

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarVeterinario(nomeVeterinario, especializacao, crmv);

                return;
            }

            EditarDados(nomeVeterinario, especializacao, crmv);
        }
        private void AdicionarVeterinario(string nomeVeterinario, string especializacao, int crmv)
        {
            var veterinario = new Veterinario
            {
                Codigo = veterinarioServico.ObterUltimoCodigo() + 1,
                NomeVeterinario = nomeVeterinario,
                Especializacao = especializacao,
                Crmv = crmv
            };

            veterinarioServico.Cadastrar(veterinario);

            LimparCampos();

            ListarVeterinarios();

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var nomeCompleto = dataGridView1.SelectedCells[1].Value.ToString();
            var especializacao = dataGridView1.SelectedCells[2].Value.ToString();
            var crmv = Convert.ToInt32(dataGridView1.SelectedCells[3].Value);

            textBoxNomeCompleto.Text = nomeCompleto;
            textBoxEspecializacao.Text = especializacao;
            textBoxCrmv.Text = crmv.ToString();
            
        }
        private void LimparCampos()
        {
            textBoxNomeCompleto.Clear();
            textBoxEspecializacao.Clear();
            textBoxCrmv.Clear();

            dataGridView1.ClearSelection();            
        }
        private void EditarDados(string nomeVeterinario, string especializazao, int crmv)
        {
            var veterinario = new Veterinario();
            veterinario.NomeVeterinario = nomeVeterinario;
            veterinario.Especializacao = especializazao;
            veterinario.Crmv = crmv;

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            veterinario.Codigo = codigo;

            veterinarioServico.Editar(veterinario);

            LimparCampos();

            ListarVeterinarios();
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar.");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                veterinarioServico.Apagar(codigoSelecionado);

                ListarVeterinarios();
            }
        }
        private void ListarVeterinarios()
        {
            var veterinarios = veterinarioServico.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                dataGridView1.Rows.Add(new Object[]
                {
                    veterinario.Codigo, veterinario.NomeVeterinario, veterinario.Especializacao, veterinario.Crmv

                });
                                
            }

            dataGridView1.ClearSelection();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private bool ValidarDados(string nomeVeterinario, string especializacao, int crmv)
        {
            if (textBoxNomeCompleto.Text == "")
            {
                MessageBox.Show("Digite o nome do veterinário.");

                textBoxNomeCompleto.Focus();

                return false;
            }

            if (textBoxEspecializacao.Text == "")
            {
                MessageBox.Show("Digite a especialização do veterinário.");

                textBoxEspecializacao.Focus();

                return false;
            }

            if (textBoxCrmv.Text == "")
            {
                MessageBox.Show("Digite o CRMV do veterinário.");

                textBoxCrmv.Focus();

                return false;
            }

            return true;
        }
    }
}
