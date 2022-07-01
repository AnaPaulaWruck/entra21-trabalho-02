using Newtonsoft.Json;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class PetsForm : Form
    {
        private PetServico petServico;
        private AlergiaServico alergiaServico;
        //private ClienteServico clienteServico;

        public PetsForm()
        {
            InitializeComponent();

            petServico = new PetServico();

            alergiaServico = new AlergiaServico();

            PreencherDataGridViewComPets();

            PreencherComboBoxcomOsNomesDasAlergias();

            //PreencherComboBoxcomOsNomesDosClientes();
        }

        private void PreencherComboBoxcomOsNomesDasAlergias()
        {
            var alergias = alergiaServico.ObterTodos();

            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];
                comboBoxAlergia.Items.Add(alergia.Nome);
            }
        }

        //private void PreencherComboBoxcomOsNomesDosClientes()
        //{
        //    var clientes = clienteServico.ObterTodos();

        //    for (int i = 0; i < clientes.Count; i++)
        //    {
        //        var cliente = clientes[i];
        //        comboBoxCliente.Items.Add(cliente.Nome);
        //    }
        //}

        private void PreencherDataGridViewComPets()
        {
            var pets = petServico.ObterTodos();

            dataGridViewPets.Rows.Clear();

            for (var i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                dataGridViewPets.Rows.Add(new object[]
                {
                    pet.Codigo,
                    pet.Nome,
                    pet.Cliente, // pet.Cliente.Nome // TODO
                    pet.Especie,
                    pet.Sexo,
                    pet.Raca,
                    pet.DataNascimento,
                    pet.Peso,
                    pet.Vacinas,
                    pet.Alergia.Nome
                });
            }

            dataGridViewPets.ClearSelection();
        }

        private void LimparCampos()
        {
            textBoxNome.Clear();
            comboBoxCliente.SelectedIndex = -1;
            radioButtonCao.Checked = false;
            radioButtonGato.Checked = false;
            textBoxRaca.Clear();
            radioButtonFemea.Checked = false;
            radioButtonMacho.Checked = false;
            dateTimePickerDataNascimento.ResetText();
            textBoxPeso.Clear();
            checkBoxVacinaAntirrabica.Checked = false;
            checkBoxVacinaGiardiase.Checked = false;
            checkBoxVacinaQuadrupla.Checked = false;
            checkBoxVacinaQuintupla.Checked = false;
            checkBoxVacinaV10.Checked = false;
            checkBoxVacinaV8.Checked = false;
            comboBoxAlergia.SelectedIndex = -1;

            dataGridViewPets.ClearSelection();
        }

        private void CadastrarPet(
            string nome, string nomeCliente, string especie, string sexo, string raca, DateTime dataNascimento,
            double peso, List<string> vacinas, string nomeAlergia)
        {
            var pet = new Pet();
            pet.Codigo = petServico.ObterUltimoCodigo() + 1;
            pet.Nome = nome;
            pet.Cliente = nomeCliente; // clienteServico.ObterPorNomeCliente(nomeCliente); TODO
            pet.Especie = especie;
            pet.Raca = raca;
            pet.Sexo = sexo;
            pet.DataNascimento = dataNascimento;
            pet.Peso = peso;
            pet.Vacinas = GerarListaVacinasSelecionadas();
            pet.Alergia = alergiaServico.ObterPorNomeAlergia(nomeAlergia);

            petServico.Adicionar(pet);
        }

        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewPets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Pet da tabela para editar.");

                return;
            }

            var linhaSelecionada = dataGridViewPets.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var pet = petServico.ObterPorCodigo(codigo);

            textBoxNome.Text = pet.Nome;
            comboBoxCliente.SelectedItem = pet.Cliente; //comboBoxCliente.SelectedItem = pet.Cliente.Nome; // TODO
            //radioButtonCao.Checked = VerificarSeRadioButtonSelecionado(radioButtonCao);
            textBoxRaca.Text = pet.Raca;
            // TODO radioButton Sexo
            dateTimePickerDataNascimento.Value = pet.DataNascimento;
            textBoxPeso.Text = pet.Peso.ToString();
            // TODO checkboxes vacinas
            comboBoxAlergia.SelectedItem = pet.Alergia.Nome;
        }

        private void EditarPet(string nome, string nomeCliente, string especie, string sexo, string raca, DateTime dataNascimento,
            double peso, List<string> vacinas, string nomeAlergia)
        {
            var linhaSelecionada = dataGridViewPets.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var pet = new Pet();
            pet.Codigo = codigoSelecionado;
            pet.Nome = nome;
            pet.Cliente = nomeCliente; // pet.Cliente = clienteServico.ObterPorNomeCliente(nomeCliente); TODO
            pet.Especie = especie;
            pet.Raca = raca;
            pet.Sexo = sexo;
            pet.DataNascimento = dataNascimento;
            pet.Peso = peso;
            pet.Vacinas = GerarListaVacinasSelecionadas();
            pet.Alergia = alergiaServico.ObterPorNomeAlergia(nomeAlergia);

            petServico.Editar(pet);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var nomeCliente = Convert.ToString(comboBoxCliente.SelectedItem);
            var especie = ObterTextoRacaPet();
            var sexo = ObterTextoSexoPet();
            var raca = textBoxRaca.Text;
            var peso = Convert.ToDouble(textBoxPeso.Text);
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var vacinas = GerarListaVacinasSelecionadas();
            var nomeAlergia = Convert.ToString(comboBoxAlergia.SelectedItem);

            var dadosValidos = ValidarDados(nome, nomeCliente, especie, sexo, raca, peso, nomeAlergia);

            if (dadosValidos == false)
            {
                return;
            }

            if (dataGridViewPets.SelectedRows.Count == 0)
                CadastrarPet(nome, nomeCliente, especie, sexo, raca, dataNascimento, peso, vacinas, nomeAlergia);
            else
                EditarPet(nome, nomeCliente, especie, sexo, raca, dataNascimento, peso, vacinas, nomeAlergia);

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Pet da lista para remover");

                return;
            }

            var resposta = MessageBox.Show(
                "Deseja realmente apagar o registro do Pet?", "Aviso",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                return;
            }
            else
            {
                MessageBox.Show("Registro apagado com sucesso!");
            }

            var linhaSelecionada = dataGridViewPets.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var pet = petServico.ObterPorCodigo(codigo);

            petServico.Apagar(pet);

            PreencherDataGridViewComPets();

            dataGridViewPets.ClearSelection();
        }

        private bool ValidarDados(string nome, string nomeCliente, string especie, string sexo, string raca,
            double peso, string nomeAlergia)
        {
            if (nome.Trim().Length < 2)
            {
                MessageBox.Show("Nome do animal inválido");

                textBoxNome.Focus();

                return false;
            }

            if (comboBoxCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um Tutor");

                comboBoxCliente.DroppedDown = true;

                return false;
            }

            if (raca.Trim().Length < 5)
            {
                MessageBox.Show("Digite um valor válido para Raça do animal");

                textBoxRaca.Focus();

                return false;
            }

            try
            {
                if (peso <= 0)
                {
                    MessageBox.Show("Peso não pode ser um valor menor ou igual a zero.");

                    textBoxRaca.Focus();

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digite um valor válido para peso.");

                textBoxRaca.Focus();

                return false;
            }

            if (comboBoxAlergia.SelectedIndex == -1)
            {
                var resposta = MessageBox.Show(
                "O animal possui alguma alergia?", "Aviso",
                MessageBoxButtons.YesNo);

                if (resposta != DialogResult.No)
                {
                    MessageBox.Show("Escolha a Alergia");

                    comboBoxAlergia.DroppedDown = true;

                    return false;
                }
            }

            if (radioButtonCao.Checked == false && radioButtonGato.Checked == false)
            {
                MessageBox.Show("Selecione a espécie do animal.");

                groupBoxEspecie.Focus();

                return false;
            }

            if (radioButtonFemea.Checked == false && radioButtonMacho.Checked == false)
            {
                MessageBox.Show("Selecione o sexo do animal.");

                groupBoxSexo.Focus();

                return false;
            }

            // TODO dataNascimento

            return true;
        }

        private string ObterTextoRacaPet()
        {
            if (radioButtonCao.Checked == true)
            {
                return radioButtonCao.Text;
            }

            return radioButtonGato.Text;
        }

        private string ObterTextoSexoPet()
        {
            if (radioButtonFemea.Checked == true)
            {
                return radioButtonFemea.Text;
            }

            return radioButtonMacho.Text;
        }

        //private bool VerificarSeRadioButtonSelecionado(bool botao)
        //{
        //    if (botao == true)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        private List<string> GerarListaVacinasSelecionadas()
        {
            var vacinas = new List<string>();

            vacinas.Clear();

            if (checkBoxVacinaAntirrabica.Checked == true)
                vacinas.Add(checkBoxVacinaAntirrabica.Text);

            if (checkBoxVacinaGiardiase.Checked == true)
                vacinas.Add(checkBoxVacinaGiardiase.Text);

            if (checkBoxVacinaQuadrupla.Checked == true)
                vacinas.Add(checkBoxVacinaQuadrupla.Text);

            if (checkBoxVacinaQuintupla.Checked == true)
                vacinas.Add(checkBoxVacinaQuintupla.Text);

            if (checkBoxVacinaV10.Checked == true)
                vacinas.Add(checkBoxVacinaV10.Text);

            if (checkBoxVacinaV8.Checked == true)
                vacinas.Add(checkBoxVacinaV8.Text);

            return vacinas;
        }
    }
}
