using projeto_estacionamento.Models;

decimal valorEntrada = 0;
decimal valorPorHora = 0;

Console.WriteLine("Digite o valor de entrada do estacionamento: ");
valorEntrada = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor da hora: ");
valorPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estac = new Estacionamento(valorEntrada, valorPorHora);

bool menuAberto = true;

do
{
    Console.WriteLine(" ");
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    int opcaoMenu = Convert.ToInt32(Console.ReadLine());

    switch (opcaoMenu)
    {
        case 1:
            estac.AdicionarVeiculo();
            break;
        case 2:
            estac.RemoverVeiculo();
            break;
        case 3:
            estac.ListarVeiculos();
            break;
        case 4:
            Console.WriteLine(" ");
            Console.WriteLine("Programa encerrado");
            menuAberto = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (menuAberto);