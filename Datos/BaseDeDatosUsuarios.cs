using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class BaseDeDatosUsuarios : BaseDeDatos<Usuario>
    {
        public override void actualizar(Usuario entidad)
        {
            string QueryActualizar = "UPDATE USUARIOS SET NOMBRE = @NOMBRE, NÚMERO_DE_CÉDULA = @NÚMERO_DE_CÉDULA, GÉNERO = @GÉNERO, EDAD = @EDAD, TELÉFONO = @TELÉFONO, DIRECCIÓN = @DIRECCIÓN, CORREO_ELECTRÓNICO = @CORREO_ELECTRÓNICO, FECHA_DE_REGISTRO = @FECHA_DE_REGISTRO, FOTOGRAFÍA = @FOTOGRAFÍA, NOMBRE_USUARIO = @NOMBRE_USUARIO, CONTRASEÑA = @CONTRASEÑA, ROL = @ROL WHERE NÚMERO_DE_CÉDULA = @NÚMERO_DE_CÉDULA";
            abrirConexión();
            SqlCommand comandoActualizar = new SqlCommand(QueryActualizar);
            comandoActualizar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_CÉDULA", entidad.NúmeroDeCédula);
            comandoActualizar.Parameters.AddWithValue("@GÉNERO", entidad.Género);
            comandoActualizar.Parameters.AddWithValue("@EDAD", entidad.Edad);
            comandoActualizar.Parameters.AddWithValue("@TELÉFONO", entidad.Teléfono);
            comandoActualizar.Parameters.AddWithValue("@DIRECCIÓN", entidad.Dirección);
            comandoActualizar.Parameters.AddWithValue("@CORREO_ELECTRÓNICO", entidad.CorreoElectrónico);
            comandoActualizar.Parameters.AddWithValue("@FECHA_DE_REGISTRO", entidad.FechaDeRegistro);
            comandoActualizar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoActualizar.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", entidad.NombreDeUsuario);
            comandoActualizar.Parameters.AddWithValue("@CONTRASEÑA", entidad.Contraseña);
            comandoActualizar.Parameters.AddWithValue("@ROL", entidad.Rol);
            ejecutarComando(comandoActualizar);
            cerrarConexión();
        }

        public override Usuario conseguir(string clave)
        {
            string QueryConseguir = "SELECT * FROM USUARIOS WHERE NÚMERO_DE_CÉDULA = @clave";
            abrirConexión();
            SqlCommand comandoConseguir = new SqlCommand(QueryConseguir);
            comandoConseguir.Parameters.AddWithValue("@clave", clave);
            ejecutarComando(comandoConseguir);
            SqlDataReader lector = comandoConseguir.ExecuteReader();
            if (lector.Read() == false)
                return null;
            else
            {
                var m = lector.GetByte((int)DatosUsuario.ROL);
                Usuario usuario = new Usuario(
                    lector.GetString((int)DatosPersona.NOMBRE),
                    lector.GetString((int)DatosPersona.NÚMERO_DE_CÉDULA),
                    lector.GetByte((int)DatosPersona.GÉNERO),
                    lector.GetInt16((int)DatosPersona.EDAD),
                    lector.GetString((int)DatosPersona.TELÉFONO),
                    lector.GetString((int)DatosPersona.DIRECCIÓN),
                    lector.GetString((int)DatosPersona.CORREO_ELECTRÓNICO),
                    lector.GetDateTime((int)DatosPersona.FECHA_DE_REGISTRO),
                    lector.GetString((int)DatosUsuario.FOTOGRAFÍA),
                    lector.GetString((int)DatosUsuario.NOMBRE_DE_USUARIO),
                    lector.GetString((int)DatosUsuario.CONTRASEÑA),
                    lector.GetByte((int)DatosUsuario.ROL));
                cerrarConexión();
                return usuario;
            }
        }

        public override void insertar(Usuario entidad)
        {
            string QueryInsertar = "INSERT INTO USUARIOS VALUES(@NOMBRE, @NÚMERO_DE_CÉDULA, @GÉNERO, @EDAD, @TELÉFONO, @DIRECCIÓN, @CORREO_ELECTRÓNICO, @FECHA_DE_REGISTRO, @FOTOGRAFÍA, @NOMBRE_USUARIO, @CONTRASEÑA, @ROL)";
            abrirConexión();
            SqlCommand comandoInsertar = new SqlCommand(QueryInsertar);
            comandoInsertar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_CÉDULA", entidad.NúmeroDeCédula);
            comandoInsertar.Parameters.AddWithValue("@GÉNERO", entidad.Género);
            comandoInsertar.Parameters.AddWithValue("@EDAD", entidad.Edad);
            comandoInsertar.Parameters.AddWithValue("@TELÉFONO", entidad.Teléfono);
            comandoInsertar.Parameters.AddWithValue("@DIRECCIÓN", entidad.Dirección);
            comandoInsertar.Parameters.AddWithValue("@CORREO_ELECTRÓNICO", entidad.CorreoElectrónico);
            comandoInsertar.Parameters.AddWithValue("@FECHA_DE_REGISTRO", entidad.FechaDeRegistro);
            comandoInsertar.Parameters.AddWithValue("@FOTOGRAFÍA", entidad.Fotografía);
            comandoInsertar.Parameters.AddWithValue("@NOMBRE_USUARIO", entidad.NombreDeUsuario);
            comandoInsertar.Parameters.AddWithValue("@CONTRASEÑA", entidad.Contraseña);
            comandoInsertar.Parameters.AddWithValue("@ROL", entidad.Rol);
            ejecutarComando(comandoInsertar);
            cerrarConexión();
        }
    }
}
