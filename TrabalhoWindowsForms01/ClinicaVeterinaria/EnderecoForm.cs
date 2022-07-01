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
    public partial class EnderecoForm : Form
    {
        private EnderecoServico enderecoServico;
        public EnderecoForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            ListarEndereco();
        }
        private void AdicionarEndereco(int numero, int cep, string enderecocompleto)
        {
            var endereco = new Endereco();
            endereco.Codigo = enderecoServico.ObterUltimoCodigo() + 1;
            endereco.Numero = numero;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecocompleto;

            enderecoServico.Adicionar(endereco);

            LimparCampos();

            ListarEndereco();
        }
        private void EditarEndereco(int numero, int cep, string enderecocompleto)
        {
            var endereco = new Endereco();
            endereco.Numero = numero;
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecocompleto;

            var linhaSelecionada = dataGridViewEnderecoCliente.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            endereco.Codigo = codigo;

            enderecoServico.Editar(endereco);

            LimparCampos();

            ListarEndereco();
        }
        private void ListarEndereco()
        {
            var enderecos = enderecoServico.ObterTodos();

            dataGridViewEnderecoCliente.Rows.Clear();

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridViewEnderecoCliente.Rows.Add(new object[]
                {
                    endereco.Codigo, endereco.EnderecoCompleto, endereco.Numero, endereco.Cep
                });
            }

            dataGridViewEnderecoCliente.ClearSelection();
        }
        private void LimparCampos()
        {
            textBoxNumero.Clear();
            textBoxCep.Clear();
            textBoxEnderecoCompleto.Clear();

            dataGridViewEnderecoCliente.ClearSelection();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt32(textBoxNumero.Text.Trim());
            var cep = Convert.ToInt32(textBoxCep.Text.Trim());
            var enderecoCompleto = textBoxEnderecoCompleto.Text.Trim();

            if (dataGridViewEnderecoCliente.SelectedRows.Count == 0)
            {
                AdicionarEndereco(numero, cep, enderecoCompleto);

                return;
            }

            EditarEndereco(numero, cep, enderecoCompleto);

        }

        private void EditarEndereco(string numero, string cep, string enderecoCompleto)
        {
            throw new NotImplementedException();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEnderecoCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione o Item");
                return;
            }
            var linhaSelecionada = dataGridViewEnderecoCliente.SelectedRows[0];

            var enderecoCompleto = linhaSelecionada.Cells[1].Value.ToString();
            var numero = linhaSelecionada.Cells[2].Value.ToString();
            var cep = linhaSelecionada.Cells[3].Value.ToString();
          

            textBoxNumero.Text = numero;
            textBoxCep.Text = cep;
            textBoxEnderecoCompleto.Text = enderecoCompleto;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridViewEnderecoCliente.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione o item.");
                return;
            }
            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridViewEnderecoCliente.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                enderecoServico.Apagar(codigoSelecionado);

                ListarEndereco();
            }
        }
        private void buttonMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
