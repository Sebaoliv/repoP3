using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio.Interfaces;
using Dominio.Repositorios;
using Dominio;
namespace ServicioWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicio.svc o Servicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicio : IServicio
    {
        public bool EliminarUsuario(DtoUsuario usr)
        {
            IRepositorioUsuario repo = new RepositorioUsuario();
            if (usr != null)
            {
                Usuario user = new Usuario
                {
                    Email = usr.Email,
                    Password = usr.Password
                };
                return repo.Delete(user);
            }
            return false;
        }
        public DtoUsuario FindById(string email)
        {
            IRepositorioUsuario repo = new RepositorioUsuario();
            Usuario user = repo.FindById(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                DtoUsuario usr = new DtoUsuario();
                usr.Email = user.Email;
                usr.Password = user.Password;
                return usr;
            }
        }

        public IEnumerable<DtoUsuario> FindByName(string email)
        {
            IRepositorioUsuario repo = new RepositorioUsuario();
            IEnumerable<Usuario> usuarios = repo.FindByName(email);
            if (usuarios != null)
            {
                List<DtoUsuario> users = new List<DtoUsuario>();
                foreach (Usuario usr in usuarios)
                {
                    users.Add(new DtoUsuario
                    {
                        Email = usr.Email,
                        Password = usr.Password,
                    }

                        );
                }
                return users;
            }
            return null;

        }

        public IEnumerable<DtoUsuario> GetTodosLosUsuarios()
        {
            IRepositorioUsuario repo = new RepositorioUsuario();
            IEnumerable<Usuario> todos = repo.FindAll();
            if (todos != null)
            {
                List<DtoUsuario> usuarios = new List<DtoUsuario>();
                foreach (Usuario usr in todos)
                {
                    usuarios.Add(new DtoUsuario
                    {
                        Email = usr.Email,
                        Password = usr.Password

                    });
                }

                return usuarios;
            }
            return null;
        }

        public bool InsertarUsuario(DtoUsuario usr)
        {
            IRepositorioUsuario rep = new RepositorioUsuario();
            if (usr != null)
            {
                Usuario user = new Usuario
                {
                    Email = usr.Email,
                    Password = usr.Password

                };
                return rep.Add(user);
            }
            return false;

        }

        public bool ModificarUsuario(DtoUsuario usr)
        {
            IRepositorioUsuario repo = new RepositorioUsuario();
            if (usr != null)
            {
                Usuario user = new Usuario
                {
                    Email = usr.Email,
                    Password = usr.Password
                };
                return repo.Update(user);
            }
            return false;
        }
    }
}

