using System.Text;
using projeto_hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cadastrando hóspedes

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Pereira");
Pessoa p2 = new Pessoa("Julia", "Fernandes");
//Pessoa p3 = new Pessoa("Hospede", "Teste");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

// Cadastrando suítes
Suite suiteBasic = new Suite(tipoSuite: "Basic", capacidade: 2, valorDiaria: 200);

Suite suiteMaster = new Suite("Master", 7, 1000);

// Criando a reserva

Reserva reserva1 = new Reserva(diasReservados: 5);
reserva1.CadastrarSuite(suiteMaster);
reserva1.CadastrarHospedes(hospedes);

// Exibindo dados da reserva

Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Suíte: {suiteMaster.TipoSuite}");
Console.WriteLine($"Quantidade de diárias: {reserva1.DiasReservados}");
Console.WriteLine($"Valor da diária: {reserva1.CalcularValorDiaria()}");