using Microsoft.EntityFrameworkCore;
using MinimalAPI.model;

namespace MinimalAPI
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options): base(options) { }
        public DbSet<Usuario> usuarios => Set<Usuario>();
        public DbSet<Noticia> noticias => Set<Noticia>();
        public DbSet<Planta> plantas => Set<Planta>();
        public DbSet<Projeto> projetos => Set<Projeto>();
        public DbSet<Comentario> comentarios => Set<Comentario>();
    }
}
