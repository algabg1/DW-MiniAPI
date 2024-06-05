using MinimalAPI.enumerator;
using System.Text.Json.Serialization;

namespace MinimalAPI.model
{
    public class Projeto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string? descricao { get; set; }
        public Usuario responsavel { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipoProjetoEnum tipoProjeto { get; set; }
    }
}
