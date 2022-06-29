using Newtonsoft.Json;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class VeterinarioServico
    {
        private List<Veterinario> veterinarios;

        public VeterinarioServico()
        {
            veterinarios = new List<Veterinario>();

            LerArquivo();
        }
        public List<Veterinario> ObterTodos()
        {
            return veterinarios;
        }
        private void LerArquivo()
        {
            if (File.Exists("veterinarios.json") == false)
            {
                return;
            }

            var veterinariosJson = File.ReadAllText("veterinarios.json");

            veterinarios = JsonConvert.DeserializeObject<List<Veterinario>>(veterinariosJson);
        }
        public void Cadastrar(Veterinario veterinario)
        {
            veterinarios.Add(veterinario);

            SalvarArquivo();
        }
        public void Editar(Veterinario veterinarioParaEditar)
        {
            var veterinario = ObterPorCodigo(veterinarioParaEditar.Codigo);

            veterinario.NomeVeterinario = veterinarioParaEditar.NomeVeterinario;
            veterinario.Especializacao = veterinarioParaEditar.Especializacao;
            veterinario.Crmv = veterinarioParaEditar.Crmv;

            SalvarArquivo();
        }
        public Veterinario ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.Codigo == codigo)
                    return veterinario;
            }

            return null;
        }
        public void Apagar(int codigo)
        {
            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.Codigo == codigo)
                {
                    veterinarios.Remove(veterinario);

                    SalvarArquivo();

                    return;
                }
            }
        }
        public int ObterUltimoCodigo()
        {
            var ultimoCodigo = 0;

            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                ultimoCodigo = veterinario.Codigo;
            }

            return ultimoCodigo;

        }
        public Veterinario ObterPorNomeVeterinario(string nomeVeterinario)
        {
            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                if (veterinario.NomeVeterinario == nomeVeterinario)
                {
                    return veterinario;
                }
            }

            return null;
        }
        private void SalvarArquivo()
        {
            var veterinarioJson = JsonConvert.SerializeObject(veterinarios);
            File.WriteAllText("veterinarios.json", veterinarioJson);
        }

    }
}
