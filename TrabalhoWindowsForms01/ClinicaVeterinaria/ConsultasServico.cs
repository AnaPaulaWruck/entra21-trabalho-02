using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class ConsultasServico
    {
        private List<Consultas> consulta;

        private ConsultasServico()
        {
            var consulta = new List<Consultas>();

            //LerArquivo();
        }
        private void Adicionar(Consultas consultas)
        {
            consulta.Add(consultas);

            //SalvarArquivo();
        }
        public List<Consultas> ObterTodasAsConsultas()
        {
            return consulta;
        }
        public Consultas ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < consulta.Count; i++)
            {
                var consultas = consulta[i];

                if (consultas.Codigo == codigo)
                {
                    return consultas;
                }
            }

            return null;
        }
    }
}
