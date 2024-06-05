
using MinimalAPI.model;
using MinimalAPI.repository;
namespace MinimalAPI.impl
{
    public class NoticiaImpl : NoticiaRepository
    {
        public bool create(Noticia entity) { return false; }
        public Noticia read(long id) { return null; }
        public bool update(Noticia entity) { return false; }
        public bool delete(Noticia entity) { return false; }
    }
}
 