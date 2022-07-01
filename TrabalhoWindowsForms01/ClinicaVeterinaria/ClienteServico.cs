using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class ClienteServico
    {
        private List<Cliente> clientes;
        public ClienteServico()
        {
            clientes = new List<Cliente>();

            LerArquivo();
        }
        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);

            SalvarArquivo();
        }
        public void Editar(Cliente clienteParaEditar)
        {
            for (var i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == clienteParaEditar.Codigo)
                {
                    cliente.Nome = clienteParaEditar.Nome;
                    cliente.DataAdesao = clienteParaEditar.DataAdesao;
                    cliente.DataNascimento = clienteParaEditar.DataNascimento;
                    cliente.Genero = clienteParaEditar.Genero;
                    cliente.Cpf = clienteParaEditar.Cpf;
                    cliente.Pet = clienteParaEditar.Pet;
                    cliente.Telefone = clienteParaEditar.Telefone;
                    cliente.ComoDeseja = clienteParaEditar.ComoDeseja;
                    cliente.Codigo = clienteParaEditar.Codigo;

                    SalvarArquivo();

                    return;
                }
            }
        }
        public void Apagar(Cliente clienteParaApagar)
        {
            for (var i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes [i];

                if (cliente.Codigo == clienteParaApagar.Codigo)
                {
                    clientes.Remove(cliente);

                    SalvarArquivo();

                    return;
                }
            }
        }
        public List<Cliente> ObterTodos()
        {
            return clientes;
        }
        public Cliente ObterPorNomeCliente(string nomeCliente)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Nome == nomeCliente)
                {
                    return cliente;
                }
            }

            return null;
        }


        public Cliente ObterPorCodigo(int codigo)
        {

            for (var i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                if (cliente.Codigo == codigo)
                    return cliente;
            }
            return null;
        }
        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                ultimoCodigo = cliente.Codigo;
            }
            return ultimoCodigo;
        }
        public void SalvarArquivo()
        {
            var clienteEmJson = JsonConvert.SerializeObject(clientes);
            File.WriteAllText("cliente.json", clienteEmJson);
        }
        public void LerArquivo()
        {
            if (File.Exists("cliente.json") == false)
            {
                return;
            }

            var clienteEmJson = File.ReadAllText("cliente.json");
            clientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteEmJson);
        }       
    }   
}
