using aula7.Models;

Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Pereira");
Pessoa p2 = new Pessoa( "Julia", "Fernandes");

Curso cursoIngles = new Curso();

cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();