using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorioUsuario
    {
        bool Add(Usuario usr);
        bool Delete(Usuario usr);
        bool Update(Usuario usr);
        Usuario FindById(string nombre);
        IEnumerable<Usuario> FindAll();
        IEnumerable<Usuario> FindByName(string nom);
    }
}
