using MinimalAPI.repository;
using MinimalAPI.model;
namespace MinimalAPI.impl
{
    public class ComentarioImpl : ComentarioRepository
    {
        public bool create(Comentario entity) { return false; }
        public Comentario read(long id) { return null; }
        public bool update(Comentario entity) { return false; }
        public bool delete(Comentario entity) { return false; }
    }
}
