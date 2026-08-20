MongoDB — comandos básicos

1. find() — buscar documentos

Busca todos os produtos:
db.produtos.find()

Buscar produtos por uma condição:

db.produtos.find({
  Cor: "COLORIDO"
})

Buscar usando mais de uma condição:

db.produtos.find({
  Cor: "Colorido",
  Preco: { $lte: 40 }
})

`$lte` significa **less than or equal** → menor ou igual a.

2. Projeção — escolher quais campos retornar

db.produtos.find(
  { Cor: "COLORIDO" },
  { Nome: 1, Cor: 1, Preco: 1, _id: 0 }
)

O segundo objeto define quais campos aparecerão no resultado

1 → incluir
0 → excluir

3. sort() — ordenar resultados

.sort({ Preco: -1 })

1  → crescente
-1 → decrescente

db.produtos.find(
  {
    Cor: "Colorido",
    Preco: { $lte: 40 }
  },
  {
    Nome: 1,
    Cor: 1,
    Preco: 1,
    _id: 0
  }
).sort({
  Preco: -1
})

4. insertOne() — inserir

db.produtos.insertOne({
  Id: 51,
  Nome: "Produto MONGO",
  Cor: "COLORIDO",
  Preco: 31.5,
  Tamanho: "P",
  Genero: "U",
  DataCadastro: "2202-05-07T14:55:00.7866667"
})

Insere um documento na collection produtos.

db.produtos.insertMany([
  {
    Id: 52,
    Nome: "Produto A",
    Preco: 50
  },
  {
    Id: 53,
    Nome: "Produto B",
    Preco: 80
  }
])

5. updateOne() — atualizar

db.produtos.updateOne(
  { Id: 3 },
  { $set: { Preco: 210.99 } }
)

Estrutura:
updateOne(
    filtro,
    alteração
)
6. `deleteOne()` — excluir

db.produtos.deleteOne({
  Id: 49
})