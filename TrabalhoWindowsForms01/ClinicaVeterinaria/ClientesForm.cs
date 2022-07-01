using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    public partial class ClientesForm : Form
    {
        private ClienteServico clienteServico;
        private PetServico petServico;
        private EnderecoServico enderecoServico;
        public ClientesForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
            petServico = new PetServico();
            enderecoServico = new EnderecoServico();

            PreencherComboBoxcomOsEnderecos();
            PreencherComboBoxcomOsPets();
        }
        public void PreencherComboBoxcomOsEnderecos()
        {
            var enderecos = enderecoServico.ObterTodos();

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];
                comboBoxEndereco.Items.Add(endereco.EnderecoCompleto);
            }

        }
        public void PreencherComboBoxcomOsPets()
        {
            var pets = petServico.ObterTodos();

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];
                comboBoxPet.Items.Add(pet.Nome);
            }
        }
        public void LimparCampos()
        {
            textBoxNome.Clear();
            dateTimePickerDataNascimento.ResetText();
            maskedTextBoxCpf.Clear();
            maskedTextBoxTelefone.Clear();
            dateTimePickerDataAdesao.ResetText();
            radioButtonMasculino.Checked = false;
            radioButtonFeminino.Checked = false;
            checkBoxEmail.Checked = false;
            checkBoxSms.Checked = false;
            checkBoxWhatsApp.Checked = false;
        }
        private void AdicionarCliente(string Nome, DateTime DataAdesao, string Endereco, DateTime DataNascimento
                                      ,string Genero ,int Cpf, string Pet,int Telefone, string ComoDeseja,int Codigo)
        {
            var cliente = new Cliente();
            cliente.Codigo = clienteServico.ObterUltimoCodigo() + 1;
            cliente.Nome = Nome;
            cliente.DataAdesao = DataAdesao;
            cliente.Endereco = Endereco;
            cliente.DataNascimento = DataNascimento;
            cliente.Genero = Genero;
            cliente.Cpf = Cpf;
            cliente.Pet = Pet;
            cliente.Telefone = Telefone;
            cliente.ComoDeseja = ComoDeseja;

            clienteServico.Adicionar(cliente);
        }
        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente para editar.");

                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelGenero_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
