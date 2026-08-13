// ---------- ARRAYS ----------

int[] array = new int[4];

// int[] array2 = {10, 20, 30, 40, 50};
// string[] nomes = {"Jan", "Fev", "Mar", "Abr"};


Console.WriteLine("Tamanho inicial array: " + array.Length);
Console.WriteLine(" ");

array = [1, 2, 3, 4]; // Atribuindo valores no geral
// array[5] = 40; //Atribuindo valor em um índice que não existe, maior que o array, DA ERRO

// PERCORRENDO COM FOR
for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

Console.WriteLine(" ");

// PERCORRENDO COM FOR EACH
foreach(int valor in array)
    Console.WriteLine(valor);

Console.WriteLine(" ");

// REDIMENSIONANDO O ARRAY
Array.Resize(ref array, array.Length + 1);

Console.WriteLine("Tamanho final array: " + array.Length);

array[4] = 40;

foreach(int valor in array)
    Console.WriteLine(valor);

Console.WriteLine(" ");

// COPIANDO UM ARRAY PARA OUTRO

int[] novoArrayDobrado = new int[array.Length * 2];
Array.Copy(array, novoArrayDobrado, array.Length);

foreach(int valor in novoArrayDobrado)
    Console.WriteLine(valor);

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

// ---------- LISTAS ----------

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MG");
listaString.Add("RJ");

foreach(string i in listaString)
    Console.WriteLine("Estado lista: " + i);