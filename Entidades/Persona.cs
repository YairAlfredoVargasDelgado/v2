using System;

namespace Entidades
{
    public enum DatosPersona
    {
        CÓDIGO, NOMBRE, NÚMERO_DE_CÉDULA, GÉNERO, EDAD, TELÉFONO,
        DIRECCIÓN, CORREO_ELECTRÓNICO, FECHA_DE_REGISTRO
    }

    public class Persona
    {
        public int Código { get; set; }
        public string Nombre { get; set; }
        public string NúmeroDeCédula { get; set; }
        public byte Género { get; set; }
        public short Edad { get; set; }
        public string Teléfono { get; set; }
        public string Dirección { get; set; }
        public string CorreoElectrónico { get; set; }
        public DateTime FechaDeRegistro { get; set; }

        public Persona(string nombre, string númeroDeCédula, byte género, short edad, string teléfono,
            string dirección, string correoElectrónico, DateTime fechaDeRegistro)
        {
            Nombre = nombre;
            NúmeroDeCédula = númeroDeCédula;
            Género = género;
            Edad = edad;
            Teléfono = teléfono;
            Dirección = dirección;
            CorreoElectrónico = correoElectrónico;
            FechaDeRegistro = fechaDeRegistro;
        }
    }
}
