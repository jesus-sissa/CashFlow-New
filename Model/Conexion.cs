using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace CashFlow.Model
{
    class Conexion
    {
        public static SqlConnection creaConexion()
        {
            string connection;
            connection = Properties.Settings.Default.Conection;

            return new SqlConnection(connection);
        }

        public static SqlTransaction creaTransaccion(string ClaveSucursal)
        {
            var connection = ConfigurationManager.AppSettings.Get("Conection");
            var cn = new SqlConnection(connection);
            cn.Open();
            return cn.BeginTransaction();
        }

        public static void creaParametro(SqlCommand cmd, string nombre, SqlDbType tipo, object valor, bool Mayusculas = false)
        {
            var prm = new SqlParameter(nombre, tipo);
            switch (tipo)
            {

                case SqlDbType.NChar:
                case SqlDbType.NText:
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                case SqlDbType.VarChar:
                    if (Mayusculas)
                    {
                        prm.Value = valor.ToString().ToUpper();
                    }
                    else
                    {
                        prm.Value = valor;
                    }
                    break;
                default:
                    prm.Value = valor;
                    break;
            }
            cmd.Parameters.Add(prm);
        }

        public static SqlCommand creaComando(string Procedimiento, SqlConnection conexion)
        {
            var cmd = new SqlCommand(Procedimiento, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static SqlCommand creaComando(string Procedimiento, SqlTransaction Transaccion)
        {
            var cmd = new SqlCommand(Procedimiento, Transaccion.Connection, Transaccion);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static DataTable ejecutaConsulta(SqlCommand cmd)
        {
            var Tbl = new DataTable();

            if (cmd.Connection.State == ConnectionState.Open)
            {
                Tbl.Load(cmd.ExecuteReader());
            }
            else
            {
                cmd.Connection.Open();
                Tbl.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
            return Tbl;
        }

        public static void ejecutaConsulta(SqlCommand cmd, DataTable Tbl)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                Tbl.Load(cmd.ExecuteReader());
            }
            else
            {
                cmd.Connection.Open();
                Tbl.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
            }
        }
        public static object ejecutaScalar(SqlCommand cmd)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                return cmd.ExecuteScalar();
            }
            else
            {
                cmd.Connection.Open();
                var res = cmd.ExecuteScalar();
                cmd.Connection.Close();

                return res;
            }
        }

        public static int ejecutarNonquery(SqlCommand cmd)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                return cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.Connection.Open();
                var res = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return res;
            }
        }
    }
}
