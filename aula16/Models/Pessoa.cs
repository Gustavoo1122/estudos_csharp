using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome) // Ao criar um construtor na classe pai, devemos adicionar a sintaxe na classe filha também
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Email { get; set; }
        public virtual void Apresentar() // Palavra vitual serve para permitir o polimorfismo pelas classes filhas
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}