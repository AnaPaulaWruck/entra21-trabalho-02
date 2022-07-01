namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class ConsultasForm : Form
    {
        private ClienteServico clienteServico;
        private PetServico petServico;
        private VeterinarioServico veterinarioServico;
        private ConsultasServico consultasServico;

        public ConsultasForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            petServico = new PetServico();
            veterinarioServico = new VeterinarioServico();
            consultasServico = new ConsultasServico();

            PreencherDataGridViewComConsultas();

            PreencherNomePet();

            PreencherNomeCliente();

            PreencherNomeVeterinario();

        }
        private void PreencherDataGridViewComConsultas()
        {
            var consultas = consultasServico.ObterTodasAsConsultas();

            dataGridViewConsultas.Rows.Clear();

            for (int i = 0; i < consultas.Count; i++)
            {
                var consulta = consultas[i];

                dataGridViewConsultas.Rows.Add(new object[]
                {
                    consulta.Codigo,
                    consulta.Pet.Nome,
                    consulta.Cliente, //.Nome
                    consulta.Veterinario.NomeVeterinario,
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
            var data = dateTimePickerDia.Value;
            var horario = dateTimePickerHorario.Value;
            var tipoConsulta = "";

            if (radioButtonUrgente.Checked)
            {
                tipoConsulta = radioButtonUrgente.Text;
            }

            if (radioButtonRotina.Checked)
            {
                tipoConsulta = radioButtonRotina.Text;
            }

            var dadosValidos = ValidarDados(pet, cliente, veterinario, data);

            if (dadosValidos == false)
            { 
                return;
            }
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                CadastrarConsulta(pet, cliente, veterinario, tipoConsulta, data, horario);
            }
            else
            {
                EditarConsultas(pet, cliente, veterinario, tipoConsulta, data, horario);
            }

        }
        private void EditarConsultas(string pet, string cliente, string veterinario, string tipoConsulta, DateTime data, DateTime hora)
        {
            var linhaSelecionada = dataGridViewConsultas.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var consultas = new Consultas();
            consultas.Codigo = codigoSelecionado;
            consultas.Pet = petServico.ObterPorNomePet(pet);
            consultas.Cliente = cliente;
            consultas.Veterinario = veterinarioServico.ObterPorNomeVeterinario(veterinario);
            consultas.TipoConsulta = tipoConsulta;
            consultas.Data = data;
            consultas.Hora = hora;

            consultasServico.Editar(consultas);
        }
        private void CadastrarConsulta(string pet, string cliente, string veterinario, string tipoConsulta, DateTime data, DateTime horario)
        {
            var consultas = new Consultas();
            consultas.Codigo = consultasServico.ObterUltimoCodigo() + 1;
            consultas.Pet = petServico.ObterPorNomePet(pet);
            consultas.Cliente = cliente;
            consultas.Veterinario = veterinarioServico.ObterPorNomeVeterinario(veterinario);
            consultas.TipoConsulta = tipoConsulta;
            consultas.Data = data;
            consultas.Hora = horario;

            consultasServico.Adicionar(consultas);


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
            var consulta = consultasServico.ObterPorCodigo(codigo);

            comboBoxPet.SelectedItem = consulta.Pet.Nome;
            comboBoxCliente.SelectedItem = consulta.Cliente;//.Nome
            comboBoxVeterinario.SelectedItem = consulta.Veterinario.NomeVeterinario;

            if (consulta.TipoConsulta == radioButtonUrgente.Text)
                radioButtonUrgente.Checked = true;
            else
                radioButtonRotina.Checked = true;
            
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

            var consulta = consultasServico.ObterPorCodigo(codigo);

            PreencherDataGridViewComConsultas();

            dataGridViewConsultas.ClearSelection();
        }
        private bool ValidarDados(string pet, string cliente, string veterinario, DateTime data)
        {
            if (comboBoxPet.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um animal de estimação.");

                comboBoxPet.DroppedDown = true;

                return false;
            }

            if (comboBoxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um cliente.");

                comboBoxCliente.DroppedDown = true;

                return false;
            }

            if (comboBoxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um veterinário para a consulta.");

                comboBoxVeterinario.DroppedDown = true;

                return false;
            }

            if(dateTimePickerDia.Value < DateTime.Now)
            {
                MessageBox.Show("Data invalida.");

                dateTimePickerDia.Value = DateTime.Now;

                return false;
            }

            if (radioButtonUrgente.Checked == false && radioButtonRotina.Checked == false)
            {
                MessageBox.Show("Selecione um tipo de consulta.");

                return false;
            }

            return true;
        }
    }
}
