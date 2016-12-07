using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BaseDeDatosTransacciones : BaseDeDatos<Transacción>
    {
        public override void actualizar(Transacción entidad)
        {
            string SqlActualizar = "UPDATE TRANSACCIONES SET(IDENTIFICACIÓN_DEL_CLIENTE, PLACA_DEL_VEHÍCULO, TOTAL, FECHA_DE_REALIZACIÓN) VALUES(@IDENTIFICACIÓN_DEL_CLIENTE, @PLACA_DEL_VEHÍCULO, @TOTAL, @FECHA_DE_REALIZACIÓN) WHERE CÓDIGO = @CÓDIGO";
            abrirConexión();
            SqlCommand comandoActualizar = new SqlCommand(SqlActualizar);
            comandoActualizar.Parameters.AddWithValue("@IDENTIFICACIÓN_DEL_CLIENTE", entidad.IdentificaciónDelCliente);
            comandoActualizar.Parameters.AddWithValue("@PLACA_DEL_VEHÍCULO", entidad.PlacaDelVehículo);
            comandoActualizar.Parameters.AddWithValue("@TOTAL", entidad.Total);
            comandoActualizar.Parameters.AddWithValue("@FECHA_DE_REALIZACIÓN", entidad.FechaDeRealización);
            ejecutarComando(comandoActualizar);
            cerrarConexión();
        }

        public override Transacción conseguir(string clave)
        {
            string QueryConseguir = "SELECT * FROM TRANSACCIONES WHERE CÓDIGO = @clave";
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
                Transacción entidad = new Transacción(
                    lector.GetInt32((int)DatosTransacción.CÓDIGO),
                    lector.GetString((int)DatosTransacción.IDENTIFICACIÓN_DEL_CLIENTE),
                    lector.GetString((int)DatosTransacción.PLACA_DEL_VEHÍCULO),
                    lector.GetFloat((int)DatosTransacción.TOTAL),
                    lector.GetDateTime((int)DatosTransacción.FECHA_DE_REALIZACIÓN));
                cerrarConexión();
                return entidad;
            }
        }

        public override void insertar(Transacción entidad)
        {
            string SqlInsertar = "INSERT INTO TRANSACCIONES (IDENTIFICACIÓN_DEL_CLIENTE, PLACA_DEL_VEHÍCULO, TOTAL, FECHA_DE_REALIZACIÓN) VALUES(@IDENTIFICACIÓN_DEL_CLIENTE, @PLACA_DEL_VEHÍCULO, @TOTAL, @FECHA_DE_REALIZACIÓN)";
            abrirConexión();
            SqlCommand comandoInsertar = new SqlCommand(SqlInsertar);
            comandoInsertar.Parameters.AddWithValue("@IDENTIFICACIÓN_DEL_CLIENTE", entidad.IdentificaciónDelCliente);
            comandoInsertar.Parameters.AddWithValue("@PLACA_DEL_VEHÍCULO", entidad.PlacaDelVehículo);
            comandoInsertar.Parameters.AddWithValue("@TOTAL", entidad.Total);
            comandoInsertar.Parameters.AddWithValue("@FECHA_DE_REALIZACIÓN", entidad.FechaDeRealización);
            ejecutarComando(comandoInsertar);
            cerrarConexión();
        }
    }
}
