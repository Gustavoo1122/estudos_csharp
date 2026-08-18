using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public sealed class Aluno : Pessoa // Para fazer a herança usamos " : ClassePai"
    { // Palavra "sealed" serve para travar a herança de uma classe, transforma em uma classe selada, que não pode ter filhos
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {
            // Quando a classe pai tem um construtor para exigir que todos os filhos tenham também
            // utilizamos " : base(nome)" isso significa que a classe filho também vai exigir a propriedade para passar ao pai
        }
        public double Nota { get; set; }

        public override void Apresentar() // palavra override permite sobrescrever o método da classe pai
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}