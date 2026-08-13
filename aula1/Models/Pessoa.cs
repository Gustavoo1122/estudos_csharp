using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    // Criando a classe
    public class Pessoa
    {
        // Criando propriedades
        public string Nome { get; set; } // Comando "prop" é um atalho para criar atributos
        public char Sexo { get; set; }
        public int Idade { get; set; }

        // Criando métodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e eu tenho {Idade} anos"); // "\n" quebra linha
        }
    }
}