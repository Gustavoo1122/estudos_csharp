using aula12.Models;
using Newtonsoft.Json;

// EXPORTANDO ARQUIVO JSON (SERIALIZE)
List<Venda> vendas = new List<Venda>();
DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Monitor", dataAtual, 395.00M);
Venda v2 = new Venda(2, "Teclado", dataAtual, 201.90M);
Venda v3 = new Venda(3, "Mouse", dataAtual, 150.00M);

vendas.Add(v1);
vendas.Add(v2);
vendas.Add(v3);

//string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

//File.WriteAllText("../arquivos/vendas.json", serializado);

// LENDO ARQUIVO JSON (DESERIALIZE)
string conteudoArquivo = File.ReadAllText("../arquivos/vendas.json");

List<VendaEntrada> vendasEntrada = JsonConvert.DeserializeObject<List<VendaEntrada>>(conteudoArquivo);

foreach(VendaEntrada venda in vendasEntrada)
{
    Console.WriteLine($"Id: {venda.Id} Produto: {venda.Produto} Data venda: {venda.DataVenda} Valor: {venda.Valor}");
}

