using MinimalAPI.model;
using MinimalAPI.repository;
namespace MinimalAPI.impl
{
    public class PlantaImpl : PlantaRepository
    {
        public bool create(Planta entity) { return false; }
        public Planta read(long id) { return null; }
        public bool update(Planta entity) { return false; }
        public bool delete(Planta entity) { return false; }
    }
}
