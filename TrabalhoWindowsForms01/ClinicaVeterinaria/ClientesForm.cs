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
        private void PreencherDataGridViewComClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridViewClientes.Rows.Clear();

            for (var i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                dataGridViewClientes.Rows.Add(new object[]
                {
                    cliente.Codigo,
                    cliente.Nome,
                    cliente.DataAdesao,
                    cliente.Endereco,
                    cliente.DataNascimento,
                    cliente.Genero,
                    cliente.Cpf,
                    cliente.Pet,
                    cliente.Telefone,
                    cliente.ComoDeseja

                });
            }

            dataGridViewClientes.ClearSelection();
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
                                      , string Genero, int Cpf, string Pet, int Telefone, string ComoDeseja, int Codigo)
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
            cliente.Codigo = Codigo;

            clienteServico.Adicionar(cliente);
        }
        private void ApresentarDadosParaEdicao()
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente para editar.");

                return;
            }
            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cliente = clienteServico.ObterPorCodigo(codigo);

            textBoxNome.Text = cliente.Nome;

            if (cliente.Genero == radioButtonMasculino.Text)
            {
                radioButtonMasculino.Checked = true;
            }
            else
            {
                radioButtonFeminino.Checked = true;
            }

            if (cliente.ComoDeseja == checkBoxEmail.Text)
            {
                checkBoxEmail.Checked = true;
            }

            if (cliente.ComoDeseja == checkBoxWhatsApp.Text)
            {
                checkBoxWhatsApp.Checked = true;
            }

            if (cliente.ComoDeseja == checkBoxSms.Text)
            {
                checkBoxSms.Checked = true;
            }
        }
        private void EditarCliente(string Nome, DateTime DataAdesao, string Endereco, DateTime DataNascimento
                                      , string Genero, int Cpf, string Pet, int Telefone, string ComoDeseja, int Codigo)
        {

            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];

            var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

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
            cliente.Codigo = Codigo;

            clienteServico.Editar(cliente);
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            var dataAdesao = dateTimePickerDataNascimento.Value;
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var endereco = Convert.ToString(comboBoxEndereco.SelectedItem);
            var cpf = Convert.ToInt32(maskedTextBoxCpf);
            var telefone = Convert.ToInt32(maskedTextBoxTelefone);
            var pet = Convert.ToString(comboBoxPet.SelectedItem);
            var genero = Convert.ToString(groupBoxGenero);
            var comoDeseja = Convert.ToString(groupBoxComoDeseja);


            //var dadosValidos = ValidarDados(nome, dataAdesao, endereco, dataNascimento, genero
            //    , cpf, pet, telefone, comoDeseja, codigo);

            //if (dadosValidos == false)
            //{
            //    return;
            //}

            //if (dataGridViewClientes.SelectedRows.Count == 0)
            //{
            //    AdicionarCliente(nome, dataAdesao, endereco, dataNascimento, genero
            //    , cpf, pet, telefone, comoDeseja, codigo);


            //}
            //else
            //{
            //    EditarCliente(nome, dataAdesao, endereco, dataNascimento, genero
            //    , cpf, pet, telefone, comoDeseja, codigo);

            //    PreencherDataGridViewComClientes();

            //    LimparCampos();
            //}
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Cliente  para remover");

                return;
            }

            var resposta = MessageBox.Show(
                "Deseja realmente apagar o registro?", "Aviso",
                MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                return;
            }
            else
            {
                MessageBox.Show("Registro apagado com sucesso!");
            }

            var linhaSelecionada = dataGridViewClientes.SelectedRows[0];

            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var cliente = clienteServico.ObterPorCodigo(codigo);

            clienteServico.Apagar(cliente);

            PreencherDataGridViewComClientes();

            dataGridViewClientes.ClearSelection();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            ApresentarDadosParaEdicao();
        }

        private bool ValidarDados(string Nome, DateTime DataAdesao, string Endereco, DateTime DataNascimento
                                      , string Genero, int Cpf, string Pet, int Telefone, string ComoDeseja, int Codigo)
        {
            if (Nome.Trim().Length < 2)
            {
                MessageBox.Show("Nome de Cliente Invalido");

                textBoxNome.Focus();

                return false;
            }
            if (dateTimePickerDataNascimento.Value > DateTime.Now)
            {
                MessageBox.Show("Data inválida.");

                dateTimePickerDataNascimento.Focus();

                return false;
            }

            if (comboBoxEndereco.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um Endereço");

                comboBoxEndereco.DroppedDown = true;

                return false;
            }
            if (dateTimePickerDataAdesao.Value > DateTime.Now)
            {
                MessageBox.Show("Data inválida.");

                dateTimePickerDataAdesao.Focus();

                return false;
            }
            if (comboBoxPet.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Pet");

                comboBoxEndereco.DroppedDown = true;

                return false;
            }
            if (checkBoxEmail.Checked == false && checkBoxSms.Checked == false && checkBoxWhatsApp.Checked == false)
            {
                MessageBox.Show("Selecione ao menos uma forma de envio.");

                groupBoxComoDeseja.Focus();

                return false;
            }
            if (radioButtonMasculino.Checked == false && radioButtonFeminino.Checked == false)
            {
                MessageBox.Show("Selecione o Genero do Cliente.");

                groupBoxGenero.Focus();

                return false;
            }
            //try
            //{
            //    if (Cpf == )
            //    {
            //        MessageBox.Show("Peso não pode ser um valor menor ou igual a zero.");

            //        maskedTextBoxCpf.Focus();

            //        return false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Digite um valor válido para peso.");

            //    textBoxRaca.Focus();

            //    return false;
            //}

            //if (cpf.Replace(".").Replace(".").Replace("-")Trim().Length != 0)
            {
                MessageBox.Show("Digite o CPF válido.");

                maskedTextBoxCpf.Focus();

                return false;
            }
            //if (telefone.Replace(".").Replace(".").Replace("-")Trim().Length != 0)
            {
                MessageBox.Show("Digite o Telefone válido.");

                maskedTextBoxTelefone.Focus();

                return false;
            }
            return true;

        }
        private string ObterGeneroCliente()
        {
            if (radioButtonMasculino.Checked == true)
            {
                return radioButtonMasculino.Text;
            }

            return radioButtonFeminino.Text;
        }
        private string ObterComoDeseja()
        {
            if (checkBoxEmail.Checked == true)
            {
                return checkBoxEmail.Text;
            }
            return checkBoxSms.Text;

            if (checkBoxSms.Checked == true)
            {
                return checkBoxSms.Text;
            }
            return checkBoxWhatsApp.Text;

            if (checkBoxWhatsApp.Checked == true)
            {
                return checkBoxWhatsApp.Text;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
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

