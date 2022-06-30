namespace TrabalhoWindowsForms01.ClinicaVeterinaria
{
    internal class Pet
    {
        public int Codigo;
        public string Nome;
        public string Tutor; // public Cliente Tutor; // Conforme classe Cliente
        public string Especie;
        public string Raca;
        public string Sexo;
        public DateTime DataNascimento;
        public double Peso;
        public List<string> Vacinas;
        public Alergia Alergia;
    }
}

//DateTimePicker1.Format = DateTimePickerFormat.Custom
//DateTimePicker1.CustomFormat = "dd/MM/yyyy"
