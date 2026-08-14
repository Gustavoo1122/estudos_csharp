// FILA (FIFO)

Console.WriteLine("FILA:");
Queue<int> fila = new Queue<int>();

fila.Enqueue(1); // Adiciona elemento no final da FILA
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int f in fila)
    Console.WriteLine(f);

Console.WriteLine("Removendo o elemento da fila: " + fila.Dequeue()); // Remove elemento do começo da FILA
fila.Enqueue(5);

foreach (int f in fila)
    Console.WriteLine(f);

// PILHA (LIFO) 

Console.WriteLine();
Console.WriteLine("PILHA:");

Stack<int> pilha = new Stack<int>();

pilha.Push(1); // Adicionar elemento na PILHA
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (int p in pilha)
    Console.WriteLine(p);

Console.WriteLine("Removendo o elemento da pilha: " + pilha.Pop()); // Remover elemento da PILHA
pilha.Push(5);

foreach (int p in pilha)
    Console.WriteLine(p);

// DICTIONARY 

Console.WriteLine();
Console.WriteLine("DICTIONARY:");

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
    Console.WriteLine(item);

foreach (var item in estados)
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");

// MANIPULANDO DICTIONARY
Console.WriteLine("");
estados.Remove("BA");
estados["SP"] = "São Paulo - Alterado";

foreach (var item in estados)
    Console.WriteLine(item);

string chave = "BA";

if (estados.ContainsKey(chave))
    Console.WriteLine($"Chave {chave} já existe na lista");
else
    Console.WriteLine($"Chave {chave} ainda não existe na lista");