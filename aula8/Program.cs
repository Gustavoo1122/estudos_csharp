// ALTERAR A LOCALIZAÇÃO PADRÃO DO SISTEMA
using System.Formats.Tar;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // en-US, pt-PT, pt-BR...

// FORMATANDO MOEDA
decimal valorMonetario = 8221.40M;

Console.WriteLine($"{ valorMonetario:C}"); // Formatando saída para Moeda, casas decimais: C3, C4, C5...

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-PT"))); // Trocar a localização específica

Console.WriteLine(" ");
// FORMATANDO PORCENTAGEM
double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P2"));

Console.WriteLine(" ");
// FORMATAÇÃO PERSONALIZADA
int numero = 345665908;

Console.WriteLine(numero.ToString("###-###-###"));

Console.WriteLine(" ");
//FORMATAÇÃO DE DATA

DateTime data = DateTime.Now;
DateTime dataInput = DateTime.Parse("10/08/2026"); // Se der erro, finaliza o programa

string dataString = "24/12/2025 23:00";

// TryParse não da erro, retorna um booleano
bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2);

if (sucesso)
    Console.WriteLine(data2);
else
    Console.WriteLine(dataString + " não é uma data válida");

Console.WriteLine(data.ToString("dd/MMMM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(dataInput);

