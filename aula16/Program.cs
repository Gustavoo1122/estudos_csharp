using aula16.Interfaces;
using aula16.Models;

Aluno a1 = new Aluno("Gustavo");

// a1.Nome = "Gustavo";
a1.Idade = 24;
a1.Email = "gustavo@gmail.com";
a1.Nota = 9;

Professor p1 = new Professor("Julia");

// p1.Nome = "Julia";
p1.Idade = 22;
p1.Salario = 3000;

p1.Apresentar();

a1.Apresentar();

Corrente c1 = new Corrente();

c1.Creditar(500);
c1.ExibirSaldo();

Computador comp = new Computador();

Console.WriteLine(comp.ToString());

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Somar(5, 10));
Console.WriteLine(calc.Dividir(10, 5));