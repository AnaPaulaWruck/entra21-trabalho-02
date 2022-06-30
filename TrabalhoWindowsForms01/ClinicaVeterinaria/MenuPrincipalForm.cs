namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            //var consultasForm = new ConsultasForm();
            //consultasForm.ShowDialog();
        }

        private void buttonPets_Click(object sender, EventArgs e)
        {
            //var petsForm = new PetsForm();
            //petsForm.ShowDialog();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            //var clientesForm = new ClientesForm();
            //clientesForm.ShowDialog();
        }

        private void buttonVeterinarios_Click(object sender, EventArgs e)
        {
            var veterinariosForm = new VeterinarioForm();
            veterinariosForm.ShowDialog();
        }

        private void buttonAlergias_Click(object sender, EventArgs e)
        {
            var alergiasForm = new AlergiasForm();
            alergiasForm.ShowDialog();
        }

        private void buttonEnderecos_Click(object sender, EventArgs e)
        {
            //var enderecosForm = new EnderecosForm();
            //enderecosForm.ShowDialog();
        }
    }
}
