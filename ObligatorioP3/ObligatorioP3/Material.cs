using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Material :Persistente<Material>
    {
        private string Codigo { get; set; }
        private string Titulo { get; set; }
        private int Anio { get; set; }
        private string Descripcion { get; set; }
        private string Imagen { get; set; }
        private List<Persona>Elenco { get; set; }
        private List<Persona>Direccion { get; set; }
        private Genero Genero { get; set; }


        public bool Validar()
        {
            return !string.IsNullOrEmpty(Codigo);
        }
    }
}
