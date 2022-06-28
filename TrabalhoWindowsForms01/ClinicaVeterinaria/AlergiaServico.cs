using Newtonsoft.Json;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class AlergiaServico
    {
        private List<Alergia> alergias;

        public AlergiaServico()
        {
            alergias = new List<Alergia>();

            LerArquivo();
        }

        public List<Alergia> ObterTodos()
        {
            return alergias;
        }

        public Alergia ObterPorNomeAlergia(string nomeAlergia)
        {
            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];

                if (alergia.Nome == nomeAlergia)
                {
                    return alergia;
                }
            }

            return null;
        }

        private void LerArquivo()
        {
            if (File.Exists("alergias.json") == false)
                return;

            var alergiasJson = File.ReadAllText("alergias.json");

            alergias = JsonConvert.DeserializeObject<List<Alergia>>(alergiasJson);
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];

                ultimoCodigo = alergia.Codigo;
            }

            return ultimoCodigo;
        }

        public Alergia ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];

                if (alergia.Codigo == codigo)
                    return alergia;
            }

            return null;
        }

        public void Cadastrar(Alergia alergia)
        {
            alergias.Add(alergia);

            SalvarArquivo();
        }

        public void Editar(Alergia alergiaParaEditar)
        {
            var alergia = ObterPorCodigo(alergiaParaEditar.Codigo);

            alergia.Nome = alergiaParaEditar.Nome;
            alergia.Causa = alergiaParaEditar.Causa;
            alergia.CodigoTratamento = alergiaParaEditar.CodigoTratamento;

            SalvarArquivo();
        }

        public void Apagar(int codigo)
        {
            for (int i = 0; i < alergias.Count; i++)
            {
                var alergia = alergias[i];

                if (alergia.Codigo == codigo)
                {
                    alergias.Remove(alergia);

                    SalvarArquivo();

                    return;
                }
            }
        }

        private void SalvarArquivo()
        {
            var alergiasJson = JsonConvert.SerializeObject(alergias);
            File.WriteAllText("alergias.json", alergiasJson);
        }
    }
}
