using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public class Professor : Pessoa // Para fazer a herança usamos " : ClassePai"
    { 
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            // Quando a classe pai tem um construtor para exigir que todos os filhos tenham também
            // utilizamos " : base(nome)" isso significa que a classe filho também vai exigir a propriedade para passar ao pai
        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar() // palavra override permite sobrescrever o método da classe pai
        { // Palavra sealed também serve para selar métodos, bloqueando de sobrescrever
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu salário é {Salario}");
        }
    }
}