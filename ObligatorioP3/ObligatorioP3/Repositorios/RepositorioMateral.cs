using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public class RepositorioMateral : Interfaces.IRepositorioMaterial
    {
        public bool Add(Material mat)
        {
            return mat.Validar() && mat.Insertar();
        }

        public bool Delete(Material mat)
        {
            return mat.Validar() && mat.Eliminar();
        }

        public IEnumerable<Material> FindAll()
        {
            throw new NotImplementedException();
        }

        public Material FindById(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Material> FindByName(string nom)
        {
            throw new NotImplementedException();
        }

        public bool Update(Material mat)
        {
            return mat.Validar() && mat.Modificar();
        }
    }
}
