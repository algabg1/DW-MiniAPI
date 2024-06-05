using MinimalAPI.model;
namespace MinimalAPI.repository
{
    public interface UsuarioRepository : GenericRepository<Usuario, long>
    {
        bool cadastrar(Usuario usuario);
        bool fazerLogin(Usuario usuario);

    }
}