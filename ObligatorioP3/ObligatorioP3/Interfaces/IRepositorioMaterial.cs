using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioMaterial
    {
        bool Add(Material mat);
        bool Delete(Material mat);
        bool Update(Material mat);
        Material FindById(string nombre);
        IEnumerable<Material> FindAll();
        IEnumerable<Material> FindByName(string nom);
    }
}
