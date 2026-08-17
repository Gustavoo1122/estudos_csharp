using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace aula12.Models
{
    public class VendaEntrada
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // Passando um atributo para a propriedade, vai ler o "Nome_Produto" mesmo estando diferente
        public string Produto { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal Valor { get; set; }

        public decimal? Desconto { get; set; }
    }
}