using System.Text.Json.Serialization;

namespace BlazorViaCep.Models
{
    // Representa o JSON de https://viacep.com.br/ws/{cep}/json/.
    // As propriedades são anuláveis porque, para um CEP inexistente, a API retorna
    // apenas { "erro": "true" } e todos os demais campos ficam ausentes.
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }
        [JsonPropertyName("logradouro")]
        public string? Rua { get; set; }
        [JsonPropertyName("complemento")]
        public string? Complemento { get; set; }
        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }
        [JsonPropertyName("localidade")]
        public string? Cidade { get; set; }
        [JsonPropertyName("uf")]
        public string? Uf { get; set; }
        [JsonPropertyName("ibge")]
        public string? Ibge { get; set; }
        [JsonPropertyName("gia")]
        public string? Gia { get; set; }
        [JsonPropertyName("ddd")]
        public string? Ddd { get; set; }
        [JsonPropertyName("siafi")]
        public string? Siafi { get; set; }
    }
}
