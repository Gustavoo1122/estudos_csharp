using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula14.Models
{
    public class MeuArray<T> // Tipo genérico, pode ser qualquer letra, mas por convenção é T
    {
        private static int Capacidade = 10;
        private int contador = 0;
        private T[] Array = new T[10];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
                Array[contador] = elemento;

            contador++;
        }

        public T this[int index]
        {
            get { return Array[index]; }
            set { Array[index] = value; }
        }
    }
}