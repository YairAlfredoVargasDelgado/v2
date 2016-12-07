using System;

namespace Entidades
{
    public enum DatosArtículo
    {
        CÓDIGO, NÚMERO_DE_SERIE, MARCA, PRECIO_DE_COMPRA, VALORIZACIÓN, PRECIO_ACTUAL, VIDA_ÚTIL,
        FECHA_DE_ADQUISICIÓN, FOTOGRAFÍA
    }

    public class Artículo
    {
        public int Código { get; set; }
        public string NúmeroDeSerie { get; set; }
        public string Marca { get; set; }
        public float PrecioDeCompra { get; set; }
        public float Valorización { get; set; }
        public float PrecioActual { get; set; }
        public short VidaÚtil { get; set; }
        public DateTime FechaDeAdquisición { get; set; }
        public string Fotografía { get; set; }

        public Artículo(string númeroDeSerie, string marca, float precioDeCompra, float valorización,
            float precioActual, short vidaÚtil, DateTime fechaDeAdquisición, string fotografía)
        {
            NúmeroDeSerie = númeroDeSerie;
            Marca = marca;
            PrecioDeCompra = precioDeCompra;
            Valorización = valorización;
            PrecioActual = precioActual;
            VidaÚtil = vidaÚtil;
            FechaDeAdquisición = fechaDeAdquisición;
            Fotografía = fotografía;
        }

    }
}
