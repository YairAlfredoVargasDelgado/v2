using System;

namespace Entidades
{
    public enum DatosCliente
    {
        TOTAL_COMPRAS = 9, CLIENTE_FRECUENTE
    }

    public class Cliente : Persona
    {
        public float TotalCompras { get; set; }
        public bool ClienteFrecuente { get; set; }

        public Cliente(string nombre, string númeroDeCédula, byte género, short edad, string teléfono,
            string dirección, string correoElectrónico, DateTime fechaDeRegistro, float totalCompras,
            bool clienteFrecuente
            ) : base(nombre, númeroDeCédula, género, edad, teléfono, dirección, correoElectrónico, fechaDeRegistro)
        {
            TotalCompras = totalCompras;
            ClienteFrecuente = clienteFrecuente;
        }
    }
}
