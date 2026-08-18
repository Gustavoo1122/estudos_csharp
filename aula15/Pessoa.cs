using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.aula15
{
    // Criando a classe
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        // Criando propriedades
        public string Nome { get; set; } // Comando "prop" é um atalho para criar atributos
        public string Sobrenome { get; set; }

        // Criando métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} {Sobrenome}"); // "\n" quebra linha
        }
    }
}