using Newtonsoft.Json;

namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class PetServico
    {
        private List<Pet> pets;

        public PetServico()
        {
            pets = new List<Pet>();

            LerArquivo();
        }

        public void Adicionar(Pet pet)
        {
            pets.Add(pet);

            SalvarArquivo();
        }

        public void Editar(Pet petParaAlterar)
        {
            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                if (pet.Codigo == petParaAlterar.Codigo)
                {
                    pet.Nome = petParaAlterar.Nome;
                    pet.Cliente = petParaAlterar.Cliente;
                    pet.Especie = petParaAlterar.Especie;
                    pet.Raca = petParaAlterar.Raca;
                    pet.Sexo = petParaAlterar.Sexo;
                    pet.DataNascimento = petParaAlterar.DataNascimento;
                    pet.Peso = petParaAlterar.Peso;
                    pet.Vacinas = petParaAlterar.Vacinas;
                    pet.Alergia = petParaAlterar.Alergia;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(Pet petParaApagar)
        {
            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                if (pet.Codigo == petParaApagar.Codigo)
                {
                    pets.Remove(pet);

                    SalvarArquivo();

                    return;
                }
            }
        }
        public List<Pet> ObterTodos()
        {
            return pets;
        }

        public Pet ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                if (pet.Codigo == codigo)
                    return pet;
            }

            return null;
        }

        public int ObterUltimoCodigo()
        {
            int ultimoCodigo = 0;

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                ultimoCodigo = pet.Codigo;
            }

            return ultimoCodigo;
        }

        public Pet ObterPorNomePet(string nomePet)
        {
            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                if (pet.Nome == nomePet)
                {
                    return pet;
                }
            }

            return null;
        }

        public void SalvarArquivo()
        {
            var petsEmJson = JsonConvert.SerializeObject(pets);
            File.WriteAllText("pets.json", petsEmJson);
        }

        public void LerArquivo()
        {
            if (File.Exists("pets.json") == false)
                return;

            var petsEmJson = File.ReadAllText("pets.json");
            pets = JsonConvert.DeserializeObject<List<Pet>>(petsEmJson);
        }
    }
}
