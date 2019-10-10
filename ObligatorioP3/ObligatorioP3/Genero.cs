using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public  class Genero :Persistente<Genero>
    {
        private string Nombre { get; set; }
        private string Descripcion { get; set; }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            throw new NotImplementedException();
        }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Descripcion);
        }

    }
}
