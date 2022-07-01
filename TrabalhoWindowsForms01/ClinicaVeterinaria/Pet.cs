namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class Pet
    {
        public int Codigo;
        public string Nome;
        public string Cliente; // public Cliente Cliente; // Conforme classe Cliente
        public string Especie;
        public string Raca;
        public string Sexo;
        public DateTime DataNascimento;
        public double Peso;
        public List<string> Vacinas;
        public Alergia Alergia;
    }
}
