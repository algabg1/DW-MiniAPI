using System.ComponentModel;
using System.Text.Json.Serialization;
using MinimalAPI.enumerator;
namespace MinimalAPI.model
{
    public class Planta
    {
        public int id {  get; set; }
        public string nome { get; set; }
        public string nomeCientifico {  get; set; }
        public string descricao { get; set; }
        public string origem { get; set; }
        public string cuidados { get; set; }
        public byte imagem { get; set; }
        public DateOnly dataRegistro { get; set; }


        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CategoriaEnum categoria { get; set; }
    }
}
