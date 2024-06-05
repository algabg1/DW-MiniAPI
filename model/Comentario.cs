using System.Runtime.InteropServices;

namespace MinimalAPI.model
{
    public class Comentario
    {
        public int id { get; set; }
        public string conteudo { get; set; }
        public Usuario publicador { get; set; }
        public Noticia noticia { get; set; }
    }
}
