using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
            
        }
    }
}