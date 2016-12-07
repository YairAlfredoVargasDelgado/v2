using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    class BaseDeDatosComponentes : BaseDeDatos<Componente>
    {
        public override void actualizar(Componente entidad)
        {
            string SqlActualizar = "UPDATE COMPONENTES SET(NÚMERO_DE_SERIE, MARCA, PRECIO_COMPRA, VALORIZACIÓN, PRECIO_ACTUAL, VIDA_ÚTIL, FECHA_DE_ADQUISICIÓN, FOTOGRAFÍA, NOMBRE) VALUES(@NÚMERO_DE_SERIE, @MARCA, @PRECIO_COMPRA, @VALORIZACIÓN, @PRECIO_ACTUAL, @VIDA_ÚTIL, @FECHA_DE_ADQUISICIÓN, @FOTOGRAFÍA, @NOMBRE) WHERE CÓDIGO = @CÓDIGO";
            abrirConexión();
            SqlCommand comandoActualizar = new SqlCommand(SqlActualizar);
            comandoActualizar.Parameters.AddWithValue("@CÓDIGO", entidad.Código);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_SERIE", entidad.NúmeroDeSerie);
            comandoActualizar.Parameters.AddWithValue("@MARCA", entidad.Marca);
            comandoActualizar.Parameters.AddWithValue("@PRECIO_COMPRA", entidad.PrecioDeCompra);
            comandoActualizar.Parameters.AddWithValue("@VALORIZACIÓN", entidad.Valorización);
            comandoActualizar.Parameters.AddWithValue("@PRECIO_ACTUAL", entidad.PrecioActual);
            comandoActualizar.Parameters.AddWithValue("@VIDA_ÚTIL", entidad.VidaÚtil);
            comandoActualizar.Parameters.AddWithValue("@FECHA_DE_ADQUISICIÓN", entidad.FechaDeAdquisición);
            comandoActualizar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoActualizar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            ejecutarComando(comandoActualizar);
            cerrarConexión();
        }

        public override Componente conseguir(string clave)
        {
            string QueryConseguir = "SELECT * FROM COMPONENTES WHERE CÓDIGO = @clave";
            abrirConexión();
            SqlCommand comandoConseguir = new SqlCommand(QueryConseguir);
            comandoConseguir.Parameters.AddWithValue("@clave", clave);
            ejecutarComando(comandoConseguir);
            SqlDataReader lector = comandoConseguir.ExecuteReader();
            if (lector.Read() == false)
                return null;
            else
            {
                Componente entidad = new Componente(
                    lector.GetString((int)DatosArtículo.NÚMERO_DE_SERIE),
                    lector.GetString((int)DatosArtículo.MARCA),
                    lector.GetFloat((int)DatosArtículo.PRECIO_DE_COMPRA),
                    lector.GetFloat((int)DatosArtículo.VALORIZACIÓN),
                    lector.GetFloat((int)DatosArtículo.PRECIO_ACTUAL),
                    lector.GetInt16((int)DatosArtículo.VIDA_ÚTIL),
                    lector.GetDateTime((int)DatosArtículo.FECHA_DE_ADQUISICIÓN),
                    lector.GetString((int)DatosArtículo.FOTOGRAFÍA),
                    lector.GetString((int)Componente.NOMBRE));
                cerrarConexión();
                return entidad;
            }
        }

        public override void insertar(Componente entidad)
        {
            string SqlInsertar = "INSERT INTO COMPONENTES (NÚMERO_DE_SERIE, MARCA, PRECIO_COMPRA, VALORIZACIÓN, PRECIO_ACTUAL, VIDA_ÚTIL, FECHA_DE_ADQUISICIÓN, FOTOGRAFÍA, NOMBRE) VALUES(@NÚMERO_DE_SERIE, @MARCA, @PRECIO_COMPRA, @VALORIZACIÓN, @PRECIO_ACTUAL, @VIDA_ÚTIL, @FECHA_DE_ADQUISICIÓN, @FOTOGRAFÍA, @NOMBRE)";
            abrirConexión();
            SqlCommand comandoInsertar = new SqlCommand(SqlInsertar);
            comandoInsertar.Parameters.AddWithValue("@CÓDIGO", entidad.Código);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_SERIE", entidad.NúmeroDeSerie);
            comandoInsertar.Parameters.AddWithValue("@MARCA", entidad.Marca);
            comandoInsertar.Parameters.AddWithValue("@PRECIO_COMPRA", entidad.PrecioDeCompra);
            comandoInsertar.Parameters.AddWithValue("@VALORIZACIÓN", entidad.Valorización);
            comandoInsertar.Parameters.AddWithValue("@PRECIO_ACTUAL", entidad.PrecioActual);
            comandoInsertar.Parameters.AddWithValue("@VIDA_ÚTIL", entidad.VidaÚtil);
            comandoInsertar.Parameters.AddWithValue("@FECHA_DE_ADQUISICIÓN", entidad.FechaDeAdquisición);
            comandoInsertar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoInsertar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            ejecutarComando(comandoInsertar);
            cerrarConexión();
        }
    }
}
