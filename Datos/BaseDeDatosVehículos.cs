using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class BaseDeDatosVehículos : BaseDeDatos<Vehículo>
    {
        public override void actualizar(Vehículo entidad)
        {
            string SqlActualizar = "UPDATE VEHÍCULOS SET(NÚMERO_DE_SERIE, MARCA, PRECIO_COMPRA, VALORIZACIÓN, PRECIO_ACTUAL, VIDA_ÚTIL, FECHA_DE_ADQUISICIÓN, FOTOGRAFÍA, TIPO, NÚMERO_DE_EJES, NÚMERO_DE_SILLAS, NÚMERO_DE_PUERTAS, PLACA, CIUDAD_DE_REGISTRO, PAÍS_DE_REGISTRO, PERSONA_RESPONSABLE) VALUES(@NÚMERO_DE_SERIE, @MARCA, @PRECIO_COMPRA, @VALORIZACIÓN, @PRECIO_ACTUAL, @VIDA_ÚTIL, @FECHA_DE_ADQUISICIÓN, @FOTOGRAFÍA, @TIPO, @NÚMERO_DE_EJES, @NÚMERO_DE_SILLAS, @NÚMERO_DE_PUERTAS, @PLACA, @CIUDAD_DE_REGISTRO, @PAÍS_DE_REGISTRO, @PERSONA_RESPONSABLE) WHERE PLACA = @PLACA";
            abrirConexión();
            SqlCommand comandoActualizar = new SqlCommand(SqlActualizar);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_SERIE", entidad.NúmeroDeSerie);
            comandoActualizar.Parameters.AddWithValue("@MARCA", entidad.Marca);
            comandoActualizar.Parameters.AddWithValue("@PRECIO_COMPRA", entidad.PrecioDeCompra);
            comandoActualizar.Parameters.AddWithValue("@VALORIZACIÓN", entidad.Valorización);
            comandoActualizar.Parameters.AddWithValue("@PRECIO_ACTUAL", entidad.PrecioActual);
            comandoActualizar.Parameters.AddWithValue("@VIDA_ÚTIL", entidad.VidaÚtil);
            comandoActualizar.Parameters.AddWithValue("@FECHA_DE_ADQUISICIÓN", entidad.FechaDeAdquisición);
            comandoActualizar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoActualizar.Parameters.AddWithValue("@TIPO", entidad.Tipo);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_EJES", entidad.NúmeroDeEjes);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_SILLAS", entidad.NúmeroDeSillas);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_PUERTAS", entidad.NúmeroDePuertas);
            comandoActualizar.Parameters.AddWithValue("@PLACA", entidad.Placa);
            comandoActualizar.Parameters.AddWithValue("@CIUDAD_DE_REGISTRO", entidad.CiudadDeRegistro);
            comandoActualizar.Parameters.AddWithValue("@PAÍS_DE_REGISTRO", entidad.PaísDeRegistro);
            comandoActualizar.Parameters.AddWithValue("@PERSONA_RESPONSABLE", entidad.PersonaResponsable);
            ejecutarComando(comandoActualizar);
            cerrarConexión();
        }

        public override Vehículo conseguir(string clave)
        {
            string QueryConseguir = "SELECT * FROM VEHÍCULOS WHERE PLACA = @clave";
            abrirConexión();
            SqlCommand comandoConseguir = new SqlCommand(QueryConseguir);
            comandoConseguir.Parameters.AddWithValue("@clave", clave);
            ejecutarComando(comandoConseguir);
            SqlDataReader lector = comandoConseguir.ExecuteReader();
            if (lector.Read() == false)
                return null;
            else
            {
                Vehículo entidad = new Vehículo(
                    lector.GetString((int)DatosArtículo.NÚMERO_DE_SERIE),
                    lector.GetString((int)DatosArtículo.MARCA),
                    lector.GetFloat((int)DatosArtículo.PRECIO_DE_COMPRA),
                    lector.GetFloat((int)DatosArtículo.VALORIZACIÓN),
                    lector.GetFloat((int)DatosArtículo.PRECIO_ACTUAL),
                    lector.GetInt16((int)DatosArtículo.VIDA_ÚTIL),
                    lector.GetDateTime((int)DatosArtículo.FECHA_DE_ADQUISICIÓN),
                    lector.GetString((int)DatosArtículo.FOTOGRAFÍA),
                    lector.GetByte((int)DatosVehículos.TIPO),
                    lector.GetByte((int)DatosVehículos.NÚMERO_DE_EJES),
                    lector.GetByte((int)DatosVehículos.NÚMERO_DE_SILLAS),
                    lector.GetByte((int)DatosVehículos.NÚMERO_DE_PUERTAS),
                    lector.GetString((int)DatosVehículos.PLACA),
                    lector.GetString((int)DatosVehículos.CIUDAD_DE_REGISTRO),
                    lector.GetString((int)DatosVehículos.PAÍS_DE_REGISTRO),
                    lector.GetString((int)DatosVehículos.PERSONA_RESPONSABLE));
                cerrarConexión();
                return entidad;
            }
        }
        
        public override void insertar(Vehículo entidad)
        {
            string SqlInsertar = "INSERT INTO VEHÍCULOS (NÚMERO_DE_SERIE, MARCA, PRECIO_COMPRA, VALORIZACIÓN, PRECIO_ACTUAL, VIDA_ÚTIL, FECHA_DE_ADQUISICIÓN, FOTOGRAFÍA, TIPO, NÚMERO_DE_EJES, NÚMERO_DE_SILLAS, NÚMERO_DE_PUERTAS, PLACA, CIUDAD_DE_REGISTRO, PAÍS_DE_REGISTRO, PERSONA_RESPONSABLE) VALUES(@NÚMERO_DE_SERIE, @MARCA, @PRECIO_COMPRA, @VALORIZACIÓN, @PRECIO_ACTUAL, @VIDA_ÚTIL, @FECHA_DE_ADQUISICIÓN, @FOTOGRAFÍA, @TIPO, @NÚMERO_DE_EJES, @NÚMERO_DE_SILLAS, @NÚMERO_DE_PUERTAS, @PLACA, @CIUDAD_DE_REGISTRO, @PAÍS_DE_REGISTRO, @PERSONA_RESPONSABLE)";
            abrirConexión();
            SqlCommand comandoInsertar = new SqlCommand(SqlInsertar);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_SERIE", entidad.NúmeroDeSerie);
            comandoInsertar.Parameters.AddWithValue("@MARCA", entidad.Marca);
            comandoInsertar.Parameters.AddWithValue("@PRECIO_COMPRA", entidad.PrecioDeCompra);
            comandoInsertar.Parameters.AddWithValue("@VALORIZACIÓN", entidad.Valorización);
            comandoInsertar.Parameters.AddWithValue("@PRECIO_ACTUAL", entidad.PrecioActual);
            comandoInsertar.Parameters.AddWithValue("@VIDA_ÚTIL", entidad.VidaÚtil);
            comandoInsertar.Parameters.AddWithValue("@FECHA_DE_ADQUISICIÓN", entidad.FechaDeAdquisición);
            comandoInsertar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoInsertar.Parameters.AddWithValue("@TIPO", entidad.Tipo);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_EJES", entidad.NúmeroDeEjes);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_SILLAS", entidad.NúmeroDeSillas);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_PUERTAS", entidad.NúmeroDePuertas);
            comandoInsertar.Parameters.AddWithValue("@PLACA", entidad.Placa);
            comandoInsertar.Parameters.AddWithValue("@CIUDAD_DE_REGISTRO", entidad.CiudadDeRegistro);
            comandoInsertar.Parameters.AddWithValue("@PAÍS_DE_REGISTRO", entidad.PaísDeRegistro);
            comandoInsertar.Parameters.AddWithValue("@PERSONA_RESPONSABLE", entidad.PersonaResponsable);
            ejecutarComando(comandoInsertar);
            cerrarConexión();
        }
    }
}