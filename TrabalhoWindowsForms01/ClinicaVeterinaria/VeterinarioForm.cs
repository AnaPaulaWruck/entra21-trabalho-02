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
    public partial class VeterinarioForm : Form
    {
        private VeterinarioServico vaterinarioServico;
        public VeterinarioForm()
        {
            InitializeComponent();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nomeVeterinario = textBoxNomeCompleto.Text.Trim();
            var especializacao = textBoxEspecializacao.Text.Trim();
            var crmv = Convert.ToInt32(textBoxCrmv.Text.Trim());

            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarVeterinario(nomeVeterinario, especializacao, crmv);

                return;
            }

            //EditarDados();
        }
        private void AdicionarVeterinario(string nomeVeterinario, string especializacao, int crmv)
        {
            var veterinario = new Veterinario
            {
                //Codigo = veterinarioServico.ObterPorCodigo() + 1;
                NomeVeterinario = nomeVeterinario,
                Especializacao = especializacao,
                Crmv = crmv
            };

            //veterinarioServico.Cadastrar(veterinario);

            LimparCampos();

            //ListarVeterinarios();

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente.");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var nomeCompleto = dataGridView1.SelectedCells[1].Value.ToString();
            var especializacao = dataGridView1.SelectedCells[2].Value.ToString();
            var crmv = Convert.ToInt32(dataGridView1.SelectedCells[3].Value);

            textBoxNomeCompleto.Text = nomeCompleto;
            textBoxEspecializacao.Text = especializacao;
            textBoxCrmv.Text = crmv.ToString();
            
        }
        private void LimparCampos()
        {
            textBoxNomeCompleto.Clear();
            textBoxEspecializacao.Clear();
            textBoxCrmv.Clear();

            dataGridView1.ClearSelection();            
        }
        private void EditarDados(string nomeVeterinario, string especializazao, int crmv)
        {
            var veterinario = new Veterinario();
            veterinario.NomeVeterinario = nomeVeterinario;
            veterinario.Especializacao = especializazao;
            veterinario.Crmv = crmv;

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            veterinario.Codigo = codigo;

            //veterinario.Editar(veterinario);

            LimparCampos();

            //ListarVeterinarios();
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var quantidadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantidadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente para apagar.");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                //veterinarioServico.Apagar(codigoSelecionado);

                //ListarVeterinarios();
            }
        }
    }
}
