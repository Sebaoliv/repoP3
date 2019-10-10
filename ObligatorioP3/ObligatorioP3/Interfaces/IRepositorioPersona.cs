using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioPersona
    {
        bool Add(Persona per);
        bool Delete(Persona per);
        bool Update(Persona per);
        Persona FindById(string nombre);
        IEnumerable<Persona> FindAll();
        IEnumerable<Persona> FindByName(string nom);
    }
}
