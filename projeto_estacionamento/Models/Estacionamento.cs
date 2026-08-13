using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public class Estacionamento
    {
        private decimal valorEntrada = 0;
        private decimal valorPorHora = 0;

        private string veiculo;
        List<string> listaVeiculos = new List<string>();

        //Construtor
        public Estacionamento(decimal valorEntrada, decimal valorPorHora)
        {
            this.valorEntrada = valorEntrada;
            this.valorPorHora = valorPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            veiculo = Console.ReadLine().ToString();
            listaVeiculos.Add(veiculo);
        }
   
        public void RemoverVeiculo()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Digite a placa do veículo para remover: ");
            veiculo = Console.ReadLine().ToString();
            listaVeiculos.Remove(veiculo);

            Console.WriteLine(" ");
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine($"O veículo {veiculo} foi removido e o preço total para {horas} horas foi de R${valorEntrada + horas * valorPorHora}");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Os veículos estacionados são:");
            foreach(string veic in listaVeiculos)
                Console.WriteLine(veic);
        }
    }
}