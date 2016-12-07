using System;

namespace Entidades
{

    public class Componente : Artículo
    {
        public const int NOMBRE = 10;
        public string Nombre { get; set; }

        public Componente(string númeroDeSerie, string marca, float precioDeCompra, float valorización,
            float precioActual, short vidaÚtil, DateTime fechaDeAdquisición, string fotografía, string nombre
            ) : base(númeroDeSerie, marca, precioDeCompra, valorización, precioActual, vidaÚtil, fechaDeAdquisición, fotografía)
        {
            Nombre = nombre;
        }
    }
}
