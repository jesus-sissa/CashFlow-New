using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CashFlow.Model.Request;

namespace CashFlow.Model.Repository
{
    class LoginRepository
    {
        public static DataTable Usuarios_Read(LoginRequest Model)
        {
            DataTable tbl;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cnn = Conexion.creaConexion();
                cmd = Conexion.creaComando("Login_Acces", cnn);
                Conexion.creaParametro(cmd, "@Clave_Usuario", SqlDbType.Int, Model.User);
                tbl = Conexion.ejecutaConsulta(cmd);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return tbl;
        }
    }
}
