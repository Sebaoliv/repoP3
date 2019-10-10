using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Episodio :Persistente<Episodio>
    {
        private int Ordinal { get; set; }
        private string Titulo { get; set; }
        private string Descripcion { get; set; }
        private int Duracion { get; set; }

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
    }
}
