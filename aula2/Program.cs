// Conversão de tipos de variáveis (Cast / Casting)

// Método Convert
string numero = "5";
int num = 5 + Convert.ToInt32(numero); // Converte a variável numero para int e possibilita o cálculo

// Método Parse
decimal num2 = 6.00M + decimal.Parse(numero); //  TipodeDado.Parse(valor)

Console.WriteLine("Número inteiro com Convert: " + num);
Console.WriteLine("Número decimal com Parse: " + num2);


// Convertendo STRINGS

string numero2 = num.ToString();

Console.WriteLine("Número string com ToString: " + numero2);


// Lidando com NULL

// Convert
int null1 = Convert.ToInt32(null); // Converte para 0

// Parse
// int null2 = int.Parse(null); //  Da erro no programa


Console.WriteLine("Convert lidando com NULL: " + null1);


// Método TryParse
// Podemos usar o TryParse para conversões, se der errado, ele não para o programa, apenas retorna 0

string a = "89,";
int b;

int.TryParse(a, out b); // Se não conseguir converter, retorna 0, podemos fazer o tratamento da exceção

if(b == 0)
    Console.WriteLine("Erro na conversão");
else
    Console.WriteLine("Número convertido: " + b);


// SWITCH

string vogal = "P";

switch (vogal)
{
    case "A":
    case "E":
    case "I":
    case "O":
    case "U":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Consoante");
        break;
}
    
