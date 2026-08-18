# Alocação de memória 

### Stack
É um tipo de memória que funciona com a ordem de Pilha
Fica na memória RAM, ou seja, armazena durante a execução do programa, armazena tipos mais simples, como variáveis int, string, bool, etc.

### Heap
Armazena objetos de tipos mais complexos, como objetos, ao instanciar uma classe, ela é armazenada na memória Stack como uma referência, e na memória Heap é onde fica o próprio objeto, armazena tanto classes, obejtos, interfaces, etc

### Limpeza de memória
Na memória **Stack** pós a execução de um método, todas as variáveis e objetos são limpos da Stack, como ela segue o modo de Pilha, será limpa "de cima para baixo", ou do último para o primeiro que chegou
Já na memória **Heap**, tem o Garbage Collector (GC) que a partir do momento que um objeto não tem mais ligação com um objeto na memória Stack, ele apaga esse objeto da Heap também

### Tipo de Valor e tipo de Referência
Variáveis tipo de **valor** contém uma instância do tipo, é o próprio valor referenciado na memória Stack, ele é mais simples.
Já as tipo de **referência** contém uma referência a uma instância do tipo, na memória Stack fica apenas a ref apontando para a memória Heap