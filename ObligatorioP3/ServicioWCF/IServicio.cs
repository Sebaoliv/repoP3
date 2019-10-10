using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        IEnumerable<DtoUsuario> GetTodosLosUsuarios();
        [OperationContract]
        bool InsertarUsuario(DtoUsuario usr);
        [OperationContract]
        DtoUsuario FindById(string email);
        [OperationContract]
        IEnumerable<DtoUsuario> FindByName(string email);
        [OperationContract]
        bool EliminarUsuario(DtoUsuario usr);
        [OperationContract]
        bool ModificarUsuario(DtoUsuario usr);






        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class DtoUsuario
    {
        public DtoUsuario() { }

        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }

    }
    [DataContract]
    public class DtoPersona
    {
        public DtoPersona() { }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public string Pais { get; set; }
        [DataMember]
        public string NombreArtistico { get; set; }
        [DataMember]
        public int NumeroRegistro { get; set; }




    }
}


