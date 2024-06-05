namespace MinimalAPI.model
{
    public class Noticia
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string conteudo { get; set; }
        public DateOnly data { get; set; }
        public byte imagem { get; set; }
        public Usuario autor { get; set; }
        public List<Comentario> comentarios { get; set; }
    }
}
