using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool Peso;
        public string Vacina;
        public Alergia Alergia;
    }
}

//DateTimePicker1.Format = DateTimePickerFormat.Custom
//DateTimePicker1.CustomFormat = "dd/MM/yyyy"
