using MinimalAPI.model;
namespace MinimalAPI.repository
{
    public interface GenericRepository <T,K>
    {
        bool create (T entity);
        T read (K id);
        bool update (T entity);
        bool delete (T entity);
    }
}
