namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class ConsultasForm : Form
    {
        private ClienteServico clienteServico;
        private PetServico petServico;
        private VeterinarioServico veterinarioServico;
        public ConsultasForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            petServico = new PetServico();
            veterinarioServico = new VeterinarioServico();

            PreencherNomePet();

            //PreencherNomeCliente()

            PreencherNomeVeterinario();

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
            //comboBoxCliente.SelectedIndex = -1;
            comboBoxVeterinario.SelectedIndex = -1;

            dataGridViewConsultas.ClearSelection();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var pet = Convert.ToString(comboBoxPet.SelectedItem);
            //var cliente = Convert.ToString(comboBoxCliente.SelectedItem);
            var veterinario = Convert.ToString(comboBoxVeterinario.SelectedItem);


        }
    }
}
