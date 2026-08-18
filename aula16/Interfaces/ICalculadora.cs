using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula16.Interfaces
{
    public interface ICalculadora // Para que você seja considerado uma calculadora, você precisa ter esses 4 métodos abaixo
    {
        int Somar(int n1, int n2); // Métodos que não tem corpo, são obrigatórios para implementação
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2) // Métodos com corpo, são opcionais, porque é possível utilizar direto por conta da interface
        {
            return n1 / n2;
        }
    }
}