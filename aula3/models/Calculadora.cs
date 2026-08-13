using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace aula3.models
{
    public class Calculadora
    {
        /// <summary>
        /// Método para somar dois números, x e y
        /// </summary>
        /// <param name="x">Primeiro número para soma</param>
        /// <param name="y">Segundo número para soma</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Método para subtrair dois números, x e y
        /// </summary>
        /// <param name="x">Primeiro número para subtração</param>
        /// <param name="y">Segundo número para subtração</param>
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double z = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {z}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno,4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada (double x)
        {
            double y = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {y}");
        }
    }
}