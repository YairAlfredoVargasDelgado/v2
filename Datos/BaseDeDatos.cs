using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class BaseDeDatos<T>
    {
        public string CadenaDeConexión { get; }
        public SqlConnection Conexión { get; set; }
        
        public BaseDeDatos()
        {
            CadenaDeConexión = Properties.Settings.Default.CadenaDeConexiónControl;
            Conexión = new SqlConnection(CadenaDeConexión);
        }

        public void abrirConexión()
        {
            Conexión.Open();
            if (Conexión.State != System.Data.ConnectionState.Open)
                throw new ExcepciónAbriendoBaseDeDatos();
        }

        public void cerrarConexión()
        {
            Conexión.Close();
            if (Conexión.State != System.Data.ConnectionState.Closed)
                throw new ExcepciónCerrandoBaseDeDatos();
        }

        public void verificarConexión()
        {
            if (Conexión.State == System.Data.ConnectionState.Broken)
                throw new ExcepciónConexiónCaída();
        }

        public void ejecutarComando(SqlCommand comando)
        {
            comando.Connection = Conexión;
            if (comando.ExecuteNonQuery() == 0)
                throw new ExcepciónEjecutandoComando();
        }

        public abstract void insertar(T entidad);

        public abstract void actualizar(T entidad);

        public void eliminar(string clave, string criterio, string nombreTabla)
        {
            string QueryEliminar = "DELETE FROM " + nombreTabla + " WHERE " + criterio + " = @CLAVE";
            abrirConexión();
            SqlCommand comandoEliminar = new SqlCommand(QueryEliminar);
            comandoEliminar.Parameters.AddWithValue("@CLAVE", clave);
            ejecutarComando(comandoEliminar);
            cerrarConexión();
        }

        public abstract T conseguir(string clave);
    }
}
