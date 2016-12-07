using System;

namespace Entidades
{
    public enum DatosVehículos
    {
        TIPO = 10, NÚMERO_DE_EJES, NÚMERO_DE_SILLAS, NÚMERO_DE_PUERTAS, PLACA, CIUDAD_DE_REGISTRO, PAÍS_DE_REGISTRO,
        PERSONA_RESPONSABLE
    }

    public class Vehículo : Artículo
    {
        public byte Tipo { get; set; }
        public byte NúmeroDeEjes { get; set; }
        public byte NúmeroDeSillas { get; set; }
        public byte NúmeroDePuertas { get; set; }
        public string Placa { get; set; }
        public string CiudadDeRegistro { get; set; }
        public string PaísDeRegistro { get; set; }
        public string PersonaResponsable { get; set; }

        public Vehículo(string númeroDeSerie, string marca, float precioDeCompra, float valorización,
            float precioActual, short vidaÚtil, DateTime fechaDeAdquisición, string fotografía,
            byte tipo, byte númeroDeEjes, byte númeroDeSillas, byte númeroDePuertas, string placa,
            string ciudadDeRegistro, string paísDeRegistro, string personaResponsable
            ) : base(númeroDeSerie, marca, precioDeCompra, valorización, precioActual, vidaÚtil, fechaDeAdquisición, fotografía)
        {
            Tipo = tipo;
            NúmeroDeEjes = númeroDeEjes;
            NúmeroDeSillas = númeroDeSillas;
            NúmeroDePuertas = númeroDePuertas;
            Placa = placa;
            CiudadDeRegistro = ciudadDeRegistro;
            PaísDeRegistro = paísDeRegistro;
            PersonaResponsable = personaResponsable;
        }
    }
}
