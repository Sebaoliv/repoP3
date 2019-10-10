using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Serie :Material    
    {
        private List<Temporada>Temporadas { get; set; }

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
