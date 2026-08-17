using aula12.Models;
using Newtonsoft.Json;

// VARIÁVEL NULL

bool? variavelNula = null;

if (variavelNula.HasValue && variavelNula.Value)
    Console.WriteLine("Variável não está nula.");
else
    Console.WriteLine("Variável está nula.");

// TIPO ANÔNIMO

string conteudoArquivo = File.ReadAllText("../arquivos/vendas.json");

List<VendaEntrada> vendasEntrada = JsonConvert.DeserializeObject<List<VendaEntrada>>(conteudoArquivo);

var listaAnonima = vendasEntrada.Select(x => new { x.Produto, x.Valor });

foreach (var i in listaAnonima)
    Console.WriteLine($"Produto: {i.Produto} Valor: {i.Valor}");

Console.WriteLine("");

// TIPO DINÂMICO

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} Valor: {variavelDinamica}");

variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} Valor: {variavelDinamica}");

variavelDinamica = false;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()} Valor: {variavelDinamica}");