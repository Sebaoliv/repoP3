using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioGenero
    {
        bool Add(Genero gen);
        bool Delete(Genero gen);
        bool Update(Genero gen);
        Genero FindById(string nombre);
        IEnumerable<Genero> FindAll();
        IEnumerable<Genero> FindByName(string nom);
    }
}
