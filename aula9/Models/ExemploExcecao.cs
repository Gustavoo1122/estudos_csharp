using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula9.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Console.WriteLine("Método 1");
            Metodo2();
        }

        public void Metodo2()
        {
            Console.WriteLine("Método 2");
            Metodo3();
        }

        public void Metodo3()
        {
            Console.WriteLine("Método 3");
            Metodo4();
        }
        
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção.");
        }
    }
}