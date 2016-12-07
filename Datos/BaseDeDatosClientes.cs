using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class BaseDeDatosClientes : BaseDeDatos<Cliente>
    {
        public override void actualizar(Cliente entidad)
        {
            string SqlActualizar = "UPDATE CLIENTES SET(NOMBRE, NÚMERO_DE_CÉDULA, GÉNERO, EDAD, TELÉFONO, DIRECCIÓN, CORREO_ELECTRÓNICO, FECHA_DE_REGISTRO, TOTAL_COMPRAS, CLIENTE_FRECUENTE) VALUES(@NOMBRE, @NÚMERO_DE_CÉDULA, @GÉNERO, @EDAD, @TELÉFONO, @DIRECCIÓN, @CORREO_ELECTRÓNICO, @FECHA_DE_REGISTRO, @TOTAL_COMPRAS, @CLIENTE_FRECUENTE) WHERE NÚMERO_DE_CÉDULA = @NÚMERO_DE_CÉDULA";
            abrirConexión();
            SqlCommand comandoActualizar = new SqlCommand(SqlActualizar);
            comandoActualizar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            comandoActualizar.Parameters.AddWithValue("@NÚMERO_DE_CÉDULA", entidad.NúmeroDeCédula);
            comandoActualizar.Parameters.AddWithValue("@GÉNERO", entidad.Nombre);
            comandoActualizar.Parameters.AddWithValue("@EDAD", entidad.Edad);
            comandoActualizar.Parameters.AddWithValue("@TELÉFONO", entidad.Teléfono);
            comandoActualizar.Parameters.AddWithValue("@DIRECCIÓN", entidad.Dirección);
            comandoActualizar.Parameters.AddWithValue("@CORREO_ELECTRÓNICO", entidad.CorreoElectrónico);
            comandoActualizar.Parameters.AddWithValue("@FECHA_DE_REGISTRO", entidad.FechaDeRegistro);
            comandoActualizar.Parameters.AddWithValue("@TOTAL_COMPRAS", entidad.TotalCompras);
            comandoActualizar.Parameters.AddWithValue("@CLIENTE_FRECUENTE", entidad.ClienteFrecuente);
            ejecutarComando(comandoActualizar);
            cerrarConexión();
        }

        public override Cliente conseguir(string clave)
        {
            string QueryConseguir = "SELECT * FROM CLIENTES WHERE NÚMERO_DE_CÉDULA = @clave";
            abrirConexión();
            SqlCommand comandoConseguir = new SqlCommand(QueryConseguir);
            comandoConseguir.Parameters.AddWithValue("@clave", clave);
            ejecutarComando(comandoConseguir);
            SqlDataReader lector = comandoConseguir.ExecuteReader();
            if (lector.Read() == false)
            {
                cerrarConexión();
                return null;
            }
            else
            {
                Cliente entidad = new Cliente(
                    lector.GetString((int)DatosPersona.NOMBRE),
                    lector.GetString((int)DatosPersona.NÚMERO_DE_CÉDULA),
                    lector.GetByte((int)DatosPersona.GÉNERO),
                    lector.GetInt16((int)DatosPersona.EDAD),
                    lector.GetString((int)DatosPersona.TELÉFONO),
                    lector.GetString((int)DatosPersona.DIRECCIÓN),
                    lector.GetString((int)DatosPersona.CORREO_ELECTRÓNICO),
                    lector.GetDateTime((int)DatosPersona.FECHA_DE_REGISTRO),
                    lector.GetFloat((int)DatosCliente.TOTAL_COMPRAS),
                    lector.GetBoolean((int)DatosCliente.CLIENTE_FRECUENTE));
                cerrarConexión();
                return entidad;
            }
        }

        public override void insertar(Cliente entidad)
        {
            string QueryInsertar = "INSERT INTO CLIENTES (NOMBRE, NÚMERO_DE_CÉDULA, GÉNERO, EDAD, TELÉFONO, DIRECCIÓN, CORREO_ELECTRÓNICO, FECHA_DE_REGISTRO, TOTAL_COMPRAS, CLIENTE_FRECUENTE) VALUES(@NOMBRE, @NÚMERO_DE_CÉDULA, @GÉNERO, @EDAD, @TELÉFONO, @DIRECCIÓN, @CORREO_ELECTRÓNICO, @FECHA_DE_REGISTRO, @TOTAL_COMPRAS, @CLIENTE_FRECUENTE)";
            abrirConexión();
            SqlCommand comandoInsertar = new SqlCommand(QueryInsertar);
            comandoInsertar.Parameters.AddWithValue("@NOMBRE", entidad.Nombre);
            comandoInsertar.Parameters.AddWithValue("@NÚMERO_DE_CÉDULA", entidad.NúmeroDeCédula);
            comandoInsertar.Parameters.AddWithValue("@GÉNERO", entidad.Nombre);
            comandoInsertar.Parameters.AddWithValue("@EDAD", entidad.Edad);
            comandoInsertar.Parameters.AddWithValue("@TELÉFONO", entidad.Teléfono);
            comandoInsertar.Parameters.AddWithValue("@DIRECCIÓN", entidad.Dirección);
            comandoInsertar.Parameters.AddWithValue("@CORREO_ELECTRÓNICO", entidad.CorreoElectrónico);
            comandoInsertar.Parameters.AddWithValue("@FECHA_DE_REGISTRO", entidad.FechaDeRegistro);
            comandoInsertar.Parameters.AddWithValue("@TOTAL_COMPRAS", entidad.TotalCompras);
            comandoInsertar.Parameters.AddWithValue("@CLIENTE_FRECUENTE", entidad.ClienteFrecuente);
            ejecutarComando(comandoInsertar);
            cerrarConexión();
        }
    }
}
