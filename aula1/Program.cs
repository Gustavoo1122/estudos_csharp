using csharp.Models; // Namespace, o "caminho" da classe Pessoa

// Declarações de variáveis

string testando = "Variável de teste";
int numero = 10;
double numero2 = 3.10;
decimal numeroDecimal = 1.90M;
bool condicao = true;

// Variável DATETIME

DateTime dataAtual = DateTime.Now; // Atribui a data e hora atual, TODAY - Atribui apenas a data com hora zerada

dataAtual = DateTime.Now.AddDays(1); // Atribui 1 dia na data atual, pode ser dias, meses, anos, horas, etc

// Criando instância da classe Pessoa

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Gustavo";
pessoa1.Idade = 24;

pessoa1.Apresentar();

// Imprimindo variáveis

Console.WriteLine("Valor da variável string: " + testando);
Console.WriteLine("Valor da variável inteira: " + numero);
Console.WriteLine("Valor da variável double: " + numero2.ToString("0.00")); // Função ToString para mostrar as duas casas decimais
Console.WriteLine("Valor da variável decimal: " + numeroDecimal);
Console.WriteLine("Valor da variável boolean: " + condicao);
Console.WriteLine("Valor da variável Data: " + dataAtual.ToString("dd/MM/yyyy")); // Formatar a data