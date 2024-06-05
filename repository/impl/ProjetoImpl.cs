using MinimalAPI.repository;
using MinimalAPI.model;
namespace MinimalAPI.impl
{
    public class ProjetoImpl : ProjetoRepository
    {
        public bool create(Projeto entity) { return false; }
        public Projeto read(long id) { return null; }
        public bool update(Projeto entity) { return false; }
        public bool delete(Projeto entity) { return false; }
    }
}
