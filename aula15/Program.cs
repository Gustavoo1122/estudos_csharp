// EXEMPLIFICANDO TIPO DE REFERÊNCIA

using csharp.aula15;

Pessoa p1 = new Pessoa("Gustavo", "Pereira");

Pessoa p2 = p1; // Não está criando uma cópia de p1, ambos apontam para o mesmo lugar na memória Heap
p2.Nome = "Julia"; // Então ao alterar apenas o p2, o p1 também é alterado, porque eles são 2 referência do mesmo objeto 

p1.Apresentar();
p2.Apresentar();

// EXEMPLIFICANDO TIPO DE DADO

int a = 10;

int b = a; // Por serem tipos primitivos, simples, eles ficam na memória Stack, armazenando o próprio valor, não uma referência
b = 60; // Então ao alterar o valor de B, é alterado apenas o B, porque ele é uma cópia do valor de A, não de uma referência

Console.WriteLine("Valor de A: " + a);
Console.WriteLine("Valor de B: " + b);