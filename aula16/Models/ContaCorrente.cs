using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public void SacarDinheiro(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} efetuado.");
            }
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponível: {Saldo}");
        }
    }
}