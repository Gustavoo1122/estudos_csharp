using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula7.Models
{
    // Criando a classe
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (String.IsNullOrWhiteSpace(value)) // Método para validar se uma string é NULL, "" ou " "
                    throw new ArgumentException("O nome não pode ser vazio!");

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        
        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0 || value > 110)
                    throw new ArgumentException("Idade inválida");

                _idade = value;
            }   
        }

        // Criando métodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} | Idade: {Idade}"); // "\n" quebra linha
        }
    }
}