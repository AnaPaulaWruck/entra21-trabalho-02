namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class ConsultasForm : Form
    {
        private ClienteServico clienteServico;
        private PetServico petServico;
        private VeterinarioServico veterinarioServico;
        private ConsultasServico consultaServico;

        public ConsultasForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            petServico = new PetServico();
            veterinarioServico = new VeterinarioServico();
            consultaServico = new ConsultasServico();

            PreencherDataGridViewComConsultas();

            PreencherNomePet();

            PreencherNomeCliente();

            PreencherNomeVeterinario();

        }
        private void PreencherDataGridViewComConsultas()
        {
            var consultas = consultaServico.ObterTodasAsConsultas();

            dataGridViewConsultas.Rows.Clear();

            for (int i = 0; i < consultas.Count; i++)
            {
                var consulta = consultas[i];

                dataGridViewConsultas.Rows.Add(new object[]
                {
                    consulta.Codigo,
                    consulta.Pet.Nome,
                    consulta.Cliente.Nome,
                    consulta.Veterinatio.NomeVeterinario,
                    consulta.TipoConsulta,
                    consulta.Data,
                    consulta.Hora
                });                  
            }

            dataGridViewConsultas.ClearSelection();
        }
        public void PreencherNomePet()
        {
            var pets = petServico.ObterTodos();

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];
                comboBoxPet.Items.Add(pet.Nome);
            }
        }
        public void PreencherNomeCliente()
        {
            var clientes = clienteServico.ObterTodos();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];
                comboBoxCliente.Items.Add(cliente.Nome);
            }

        }
        public void PreencherNomeVeterinario()
        {
            var veterinarios = veterinarioServico.ObterTodos();

            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];
                comboBoxVeterinario.Items.Add(veterinario.NomeVeterinario);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            comboBoxPet.SelectedIndex = -1;
            comboBoxCliente.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;
            radioButtonUrgente.Checked = false;
            radioButtonRotina.Checked = false;
            dateTimePickerDia.ResetText();
            dateTimePickerHorario.ResetText();
            checkedListBoxSintomas.ClearSelected();
            dataGridViewConsultas.ClearSelection();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var pet = Convert.ToString(comboBoxPet.SelectedItem);
            var cliente = Convert.ToString(comboBoxCliente.SelectedItem);
            var veterinario = Convert.ToString(comboBoxVeterinario.SelectedItem);

            //var dadosValidos = ValidarDados(pet, cliente, veterinario);

            //if (dadosValidos == false)
            //{ 
            //     return;
            //}
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                //Cadastrar
            }

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }
        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para edição.");

                return;
            }

            var linhaSelecionada = dataGridViewConsultas.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var consulta = consultaServico.ObterPorCodigo(codigo);

            comboBoxPet.SelectedItem = consulta.Pet.Nome;
            comboBoxCliente.SelectedItem = consulta.Cliente.Nome;
            comboBoxVeterinario.SelectedItem = consulta.Veterinatio.NomeVeterinario;
            
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algo para apagar.");

                return;
            }

            var resposta = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("Registro não foi apagado!");

                return;
            }

            var linhaSelecionada = dataGridViewConsultas.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var consulta = consultaServico.ObterPorCodigo(codigo);

            PreencherDataGridViewComConsultas();

            dataGridViewConsultas.ClearSelection();
        }

        //Criar o método Validar dados.
    }
}
