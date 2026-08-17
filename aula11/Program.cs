using aula11.Models;

(int, string, string, decimal) tupla = (1, "Gustavo", "Pereira", 1.93M);

Console.WriteLine($"ID: {tupla.Item1} Nome: {tupla.Item2} Sobrenome: {tupla.Item3} Altura: {tupla.Item4}");
Console.WriteLine("");

// Outras formas de declarar, mas a anterior é a mais recomendada e legível
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Gustavo", "Pereira", 1.93M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Gustavo", "Pereira", 1.93M);

LeituraArquivo lerArquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = lerArquivo.LerArquivo("../arquivos/arquivoLeitura.txt");
// Se tiver alguma informação retornada que não vai ser usada, colocamos um _

if (sucesso)
{
    foreach (string linha in linhasArquivo)
        Console.WriteLine(linha);
}
else
    Console.WriteLine("Erro na leitura do arquivo.");


// IF TERNÁRIO

int numero = 9;
bool isPar = false;

isPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é: " + (isPar ? "PAR" : "ÍMPAR"));