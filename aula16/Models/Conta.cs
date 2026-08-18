using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public abstract class Conta // Para criar uma classe abstrata, usar a palavra "abstract"
    {
        protected decimal Saldo; // Protected apenas a classe atual e suas classes filhas podem acessar essa propriedade

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}