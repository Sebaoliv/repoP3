using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public class RepositorioGenero : Interfaces.IRepositorioGenero
    {
        public bool Add(Genero gen)
        {
            return gen != null && gen.Validar() && gen.Insertar();
            
        }

        public bool Delete(Genero gen)
        {
            return gen != null && gen.Validar() && gen.Eliminar();
        }

        public IEnumerable<Genero> FindAll()
        {
            throw new NotImplementedException();
        }

        public Genero FindById(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genero> FindByName(string nom)
        {
            throw new NotImplementedException();
        }

        public bool Update(Genero gen)
        {
            return gen != null && gen.Validar() && gen.Modificar();
        }
    }
}
