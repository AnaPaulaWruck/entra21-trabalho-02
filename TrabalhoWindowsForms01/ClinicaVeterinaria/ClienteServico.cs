using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class ClienteServico
    {
        private List<Cliente> cliente;


        public ClienteServico()
        {
            cliente = new List<Cliente>();

            LerArquivo();
        }
        public void Adicionar(Cliente cliente)
        {
            cliente.Add(cliente);

            SalvarArquivo();

        }
        public void LerArquivo()
        {
            if (File.Exists("pets.json") == false)
            {
                return;
            }

            var clienteEmJson = File.ReadAllText("cliente.json");
            cliente = JsonConvert.DeserializeObject<List<Cliente>>(clienteEmJson);
        }
        public void SalvarArquivo()
        {
            var clienteEmJson = JsonConvert.SerializeObject(cliente);
            File.WriteAllText("cliente.json", clienteEmJson);
        }

    }
    

}
