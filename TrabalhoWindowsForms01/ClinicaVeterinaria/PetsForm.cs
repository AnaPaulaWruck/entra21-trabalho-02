using Newtonsoft.Json;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class PetsForm : Form
    {
        private PetServico petServico;
        private AlergiaServico alergiaServico;
        //private ClienteServico clienteServico; // TODO

        public PetsForm()
        {
            InitializeComponent();

            petServico = new PetServico();

            alergiaServico = new AlergiaServico();

            PreencherDataGridViewComPets();

            PreencherComboBoxcomOsNomesDasAlergias();

            //PreencherComboBoxcomOsNomesDosTutores(); // TODO
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
                    pet.Tutor, // pet.Cliente.Nome // Tutor TODO
                    pet.Especie,
                    pet.Raca,
                    pet.Sexo,
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
            comboBoxTutor.SelectedIndex = -1;
            radioButtonCao.Checked = false;
            radioButtonGato.Checked = false;
            textBoxRaca.Clear();
            radioButtonFeminino.Checked = false;
            radioButtonMasculino.Checked = false;
            //dateTimePickerDataNascimento // TODO
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
            string nome, string tutor, string especie, string raca, string sexo, DateTime dataNascimento,
            double peso, List<string> vacinas, string? nomeAlergia)
        {
            var pet = new Pet();
            pet.Codigo = petServico.ObterUltimoCodigo() + 1;
            pet.Nome = nome;
            pet.Tutor = tutor;
            pet.Especie = especie;
            pet.Raca = raca;
            pet.Sexo = sexo;
            pet.DataNascimento = dataNascimento;
            pet.Peso = peso;
            pet.Vacinas = vacinas;
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
            comboBoxTutor.SelectedItem = pet.Tutor; //comboBoxTutor.SelectedItem = pet.Cliente.Nome; // TODO
            // TODO radioButton Especie
            textBoxRaca.Text = pet.Raca;
            // TODO radioButton Sexo
            //dateTimePickerDataNascimento TODO
            textBoxPeso.Text = pet.Peso.ToString();
            // TODO checkboxes
            comboBoxAlergia.SelectedItem = pet.Alergia.Nome;
        }

        private void EditarPet(string nome, string tutor, string especie, string raca, string sexo, DateTime dataNascimento,
            double peso, List<string> vacinas, string nomeAlergia)
        {
            var linhaSelecionada = dataGridViewPets.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var pet = new Pet();
            pet.Codigo = codigoSelecionado;
            pet.Nome = nome;
            pet.Tutor = tutor; // pet.Tutor = clienteServico.ObterPorNomeCliente(tutor); TODO
            pet.Especie = especie;
            pet.Raca = raca;
            pet.Sexo = sexo;
            pet.DataNascimento = dataNascimento;
            pet.Peso = peso;
            pet.Vacinas = vacinas; // TODO
            pet.Alergia = alergiaServico.ObterPorNomeAlergia(nomeAlergia);

            petServico.Editar(pet);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
