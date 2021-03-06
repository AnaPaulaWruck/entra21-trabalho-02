using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }
        public void Editar(Endereco enderecoParaEditar)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == enderecoParaEditar.Codigo)
                {
                    endereco.EnderecoCompleto = enderecoParaEditar.EnderecoCompleto;
                    endereco.Cep = enderecoParaEditar.Cep;
                    endereco.Numero = enderecoParaEditar.Numero;


                    SalvarArquivo();

                    return;
                }
            }
        }
        public void Apagar(int codigo)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == codigo)
                {
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }
        public Endereco ObterPorCodigo(int codigo)
        {
            for (var i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Codigo == codigo)
                    return endereco;
            }
            return null;
        }
        private void SalvarArquivo()
        {
            var enderecosJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosJson);
        }

        private void LerArquivo()
        {
            if (File.Exists("enderecos.json") == false)
                return;

            var enderecosJson = File.ReadAllText("enderecos.json");

            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosJson);
        }
        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                ultimoCodigo = endereco.Codigo;
            }
            return ultimoCodigo;
        }

        public Endereco ObterPorEnderecoCompleto(string enderecoCompleto)
        {
            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.EnderecoCompleto == enderecoCompleto)
                {
                    return endereco;
                }
            }

            return null;
        }
    }
}
