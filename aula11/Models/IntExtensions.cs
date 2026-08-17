using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula11.Models
{
    public static class IntExtensions
    {
        public static bool IsPar(this int numero) // Sempre que eu declarar um inteiro ele terá acesso a esse método
        {
            return numero % 2 == 0;
        }
    }
}