using System.Reflection;

int numero = 0;
int contador = 0;

// FOR LOOP
// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// WHILE LOOP
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;

    if(contador == 6) break;
}

int soma = 0;

// DO WHILE LOOP
do
{
    Console.WriteLine("Digite um número (0 para sair)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine("Soma total dos números " + soma);

// MENU COM DO WHILE (Pode ser feito com While(true) e Environment.Exit(0) para sair do loop)

string opcao;

do
{
    Console.WriteLine("Escolha uma opção (Digite apenas o número):");
    Console.WriteLine("1 - Compras");
    Console.WriteLine("2 - Suporte");
    Console.WriteLine("3 - Falar com Atendente");
    Console.WriteLine("4 - Encerrar atendimento");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Comprando produto");
            break;
        case "2":
            Console.WriteLine("Acionando suporte");
            break;
        case "3":
            Console.WriteLine("Falando com atendente");
            break;
        case "4":
            Console.WriteLine("Encerrando atendimento");
            break;
    }
}while(opcao != "4");