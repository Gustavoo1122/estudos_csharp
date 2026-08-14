using System.Xml;
using aula9.Models;

ExemploExcecao exemplo = new ExemploExcecao();

try
{
    exemplo.Metodo1();
}
catch (Exception ex)
{
    Console.WriteLine("Exceção do Método 4: " + ex.Message);
}

try
{
    string[] linhas = File.ReadAllLines("../arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
        Console.WriteLine(linha);
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("Diretório não encontrado. Erro: " + ex.Message);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Arquivo não encontrado. Erro: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Exceção genérica. Erro: " + ex.Message);
}
finally
{
    Console.WriteLine("Processo finalizado.");
}