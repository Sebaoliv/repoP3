using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public class RepositorioUsuario : Interfaces.IRepositorioUsuario
    {
        public bool Add(Usuario usr)
        {
            return usr.Validar() && usr.Insertar();
        }

        public bool Delete(Usuario usr)
        {
            return usr.Validar() && usr.Modificar();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindByName(string nom)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario usr)
        {
            return usr.Validar() && usr.Modificar();
        }
    }
}
