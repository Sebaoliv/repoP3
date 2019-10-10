using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Dominio
{
    public class Usuario :Persistente<Usuario>
    {
        public string Email {get; set;}
        public string Password { get; set; }


        public bool Validar()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }

        public override bool Insertar()
        {
            CommandType tipo = CommandType.StoredProcedure;
            SqlConnection con = new SqlConnection(connectionString);
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter(Email, this.Email));
            parametros.Add(new SqlParameter(Password, this.Password));
            int resultado = EjecutarNoQuery(con, tipo, parametros);
            if (resultado != 0) {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override bool Eliminar()
        {
            throw new NotImplementedException();
            //string sql = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            //SqlConnection cn = CrearConexion(sql);
            //SqlTransaction trn = null;
            //try
            //{
            //    string cadenaCmd =
            //       @"DELETE FROM USUARIO WHERE EMAIL=@EMAIL";
            //    SqlCommand cmd =
            //       new SqlCommand(cadenaCmd, cn);
            //    cmd.Parameters.AddWithValue("@email", this.Email);
            //    cmd.Parameters.AddWithValue("@pwd", this.Password);
            //    cn.Open();
            //    trn = cn.BeginTransaction();
            //    cmd.Transaction = trn;
            //    trn.Commit();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    trn.Rollback();
            //    return false;
            //}
            //finally
            //{
            //    cn.Close();
            //}
        }

    

        public override bool Modificar()
        {
            //string sql = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            //SqlConnection cn = CrearConexion(sql);
            //SqlTransaction trn = null;
            //try
            //{
            //    string cadenaCmd =
            //       @"UPDATE USUARIO SET PWD=@PWD WHERE EMAIL=@EMAIL";
            //    SqlCommand cmd =
            //       new SqlCommand(cadenaCmd, cn);
            //    cmd.Parameters.AddWithValue("@email", this.Email);
            //    cn.Open();
            //    trn = cn.BeginTransaction();
            //    cmd.Transaction = trn;
            //    trn.Commit();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    trn.Rollback();
            //    return false;
            //}
            //finally
            //{
            //    cn.Close();
            //}
            throw new NotImplementedException();
        }
    }
}
