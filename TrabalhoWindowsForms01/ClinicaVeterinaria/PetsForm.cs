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
                    pet.Vacina,
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
            comboBoxRaca.SelectedIndex = -1;
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
    }
}
