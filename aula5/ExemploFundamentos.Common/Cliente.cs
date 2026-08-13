namespace ExemploFundamentos.Common.Models;

/// <summary>
/// Representa uma pessoa física, digitar /// para criar
/// </summary>
public class Cliente
{
    public string? Nome { get; set; }

    /// <summary>
    /// Faz a pessoa se apresentar, imprimindo o Nome
    /// </summary>
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }
}
