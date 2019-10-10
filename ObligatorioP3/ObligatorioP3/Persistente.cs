using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Dominio
{
    public abstract class Persistente<T>
    {
        public abstract bool Insertar();
        public abstract bool Eliminar();
        public abstract bool Modificar();
      

          public string connectionString = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;


        // public string connectionString= ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;

        public int EjecutarNoQuery(SqlConnection con, CommandType tipo, List<SqlParameter> parameters)
        {
            
        int result = 0;
            SqlCommand cmd = new SqlCommand("INSERTAR_USUARIO", con)
            {
                CommandType = tipo
            };
            foreach (SqlParameter par in parameters){
                cmd.Parameters.AddWithValue("@" + par.ParameterName,par.Value);
            }
            try
            {
                con.Open();
                result=cmd.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                con.Close();
                
                    }
            return result;


        }
        public SqlTransaction EjecutarNoQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parametros, SqlTransaction trans)
        {
            throw new NotImplementedException();
        }
        public SqlDataReader EjecutarQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parameters)
        {
            SqlDataReader result = null;
            SqlCommand cmd = new SqlCommand("INSERTAR", con)
            {
                CommandType = tipo
            };
            foreach (SqlParameter par in parameters)
            {
                cmd.Parameters.AddWithValue("@" + par.ParameterName, par.Value);
            }
            try
            {
                con.Open();
                result = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();

            }
            return result;
        }
    }
}
