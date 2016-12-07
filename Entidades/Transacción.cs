using System;

namespace Entidades
{
    public enum DatosTransacción
    {
        CÓDIGO, IDENTIFICACIÓN_DEL_CLIENTE, PLACA_DEL_VEHÍCULO, TOTAL, FECHA_DE_REALIZACIÓN
    }

    public class Transacción
    {
        public int Código { get; set; }
        public string IdentificaciónDelCliente { get; set; }
        public string PlacaDelVehículo { get;set; }
        public float Total { get; set; }
        public DateTime FechaDeRealización { get; set; }

        public Transacción(int código, string identificaciónDelCliente, string placaDelVehículo,
            float total, DateTime fechaDeRealización)
        {
            Código = código;
            IdentificaciónDelCliente = identificaciónDelCliente;
            PlacaDelVehículo = placaDelVehículo;
            Total = total;
            FechaDeRealización = fechaDeRealización;
        }
    }
}
