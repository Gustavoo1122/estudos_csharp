using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; } 
        public DateTime DataVenda { get; set; } 

        public Venda (int id, string produto, DateTime dataVenda, decimal valor)
        {
            Id = id;
            Produto = produto;
            DataVenda = dataVenda;
            Valor = valor;
        }
    }
}