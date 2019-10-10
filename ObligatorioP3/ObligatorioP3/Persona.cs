using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona :Persistente<Persona>
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Pais { get; set; }
        private string NombreArtistico { get; set; }
        private int NumeroRegistro { get; set; }


        public bool Validar()
        {
            return !string.IsNullOrEmpty(Nombre) &&NumeroRegistro>0; 
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }
            

        
        //    string sql = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
        //    SqlConnection cn = CrearConexion(sql);
        //    SqlTransaction trn = null;
        //    try
        //    {
        //        string cadenaCmd =
        //           @"INSERT INTO PERSONA 
        //        VALUES(@nombre,@apellido,@pais,@nom_artistico,@num_registro)";
        //        SqlCommand cmd =
        //           new SqlCommand(cadenaCmd, cn);
        //        cmd.Parameters.AddWithValue("@nombre", this.Nombre);
        //        cmd.Parameters.AddWithValue("@apellido", this.Apellido);
        //        cmd.Parameters.AddWithValue("@pais", this.Pais);
        //        cmd.Parameters.AddWithValue("@nom_artistico", this.NombreArtistico);
        //        cmd.Parameters.AddWithValue("@num_registro", this.NumeroRegistro);
        //        cn.Open();
        //        trn = cn.BeginTransaction();
        //        cmd.Transaction = trn;
        //        trn.Commit();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        trn.Rollback();
        //        return false;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
     

        public override bool Modificar()
        {
            //string sql = ConfigurationManager.ConnectionStrings["miConexion"].ConnectionString;
            //SqlConnection cn = CrearConexion(sql);
            //SqlTransaction trn = null;
            //try

            //{
            //    trn = cn.BeginTransaction();
            //    string cadenaCmd =
            //       @"UPDATE PERSONA SET nombre=@nombre,apellido=@apellido,pais=@pais,nom_artistico=@nom_artistico,num_registro=@num_registro
            //    VALUES(@nombre,@apellido,@pais,@nom_artistico,@num_registro)";
            //    SqlCommand cmd =
            //       new SqlCommand(cadenaCmd, cn);
            //    cmd.Parameters.AddWithValue("@nombre", this.Nombre);
            //    cmd.Parameters.AddWithValue("@apellido", this.Apellido);
            //    cmd.Parameters.AddWithValue("@pais", this.Pais);
            //    cmd.Parameters.AddWithValue("@nom_artistico", this.NombreArtistico);
            //    cmd.Parameters.AddWithValue("@num_registro", this.NumeroRegistro);
            //    cn.Open();
            //    cmd.ExecuteNonQuery();

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
