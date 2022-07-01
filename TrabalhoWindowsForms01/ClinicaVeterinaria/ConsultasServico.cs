using Newtonsoft.Json;
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

        public ConsultasServico()
        {
            consulta = new List<Consultas>();

            LerArquivo();
        }
        public void LerArquivo()
        {
            if (File.Exists("consulta.json") == false)
                return;

            var consultaJson = File.ReadAllText("consulta.json");
            consulta = JsonConvert.DeserializeObject<List<Consultas>>(consultaJson);
        }
        public void Adicionar(Consultas consultas)
        {
            consulta.Add(consultas);

            SalvarArquivo();
        }
        public void SalvarArquivo()
        {
            var consultaJson = JsonConvert.SerializeObject(consulta);
            File.WriteAllText("consulta.json", consultaJson);
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
        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < consulta.Count; i++)
            {
                var consultas = consulta[i];

                ultimoCodigo = consultas.Codigo;
            }

            return ultimoCodigo;
        }
        public void Editar(Consultas consultaParaAlterar)
        {
            for (int i = 0; i < consulta.Count; i++)
            {
                var consultas = consulta[i];

                if (consultas.Codigo == consultaParaAlterar.Codigo)
                {
                    consultas.Pet.Nome = consultaParaAlterar.Pet.Nome;
                    consultas.Cliente /*.Nome*/ = consultaParaAlterar.Cliente;//.Nome
                    consultas.Veterinario.NomeVeterinario = consultaParaAlterar.Veterinario.NomeVeterinario;
                    consultas.TipoConsulta = consultaParaAlterar.TipoConsulta;
                    consultas.Data = consultaParaAlterar.Data;
                    consultas.Hora = consultaParaAlterar.Hora;

                    SalvarArquivo();

                    return;
                }
            }
        }
        public void Apagar(Consultas consultasParaApagar)
        {
            for (int i = 0; i < consulta.Count; i++)
            {
                var consultas = consulta[i];

                if (consultas.Codigo == consultasParaApagar.Codigo)
                {
                    consulta.Remove(consultas);

                    SalvarArquivo();

                    return;
                }
            }
        }
    }
}
