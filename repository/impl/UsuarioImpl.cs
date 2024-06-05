using MinimalAPI.repository;
using MinimalAPI.model;
namespace MinimalAPI.impl
{
    public class UsuarioImpl : UsuarioRepository
    {
        public bool create(Usuario entity) { return false; }
        public Usuario read(long id) { return null; }
        public bool update(Usuario entity) { return false; }
        public bool delete(Usuario entity) { return false; }

        public bool cadastrar(Usuario usuario) {  return false; }


        public bool fazerLogin(Usuario usuario) { return false; }

    }
}
