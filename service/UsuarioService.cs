using MinimalAPI.model;
namespace MinimalAPI.service
{
    public interface UsuarioService
    {
        bool cadastrar(Usuario usuario);
        bool fazerLogin(Usuario usuario);

    }
}