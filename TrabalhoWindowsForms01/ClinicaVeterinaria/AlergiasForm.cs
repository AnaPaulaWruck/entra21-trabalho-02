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
    public partial class AlergiasForm : Form
    {
        private AlergiaServico alergiaServico;

        public AlergiasForm()
        {
            InitializeComponent();

            alergiaServico = new AlergiaServico();

            //ListarAlergias();
        }

        private void AdicionarAlergia(string nome, string causa, int codigoTratamento)
        {
            var alergia = new Alergia();
            alergia.Codigo = alergiaServico.ObterUltimoCodigo() + 1;
            alergia.Nome = nome;
            alergia.Causa = causa;
            alergia.CodigoTratamento = codigoTratamento;

            alergiaServico.Cadastrar(alergia);

            //LimparCampos();

            //ListarAlergias();
        }
    }
}
