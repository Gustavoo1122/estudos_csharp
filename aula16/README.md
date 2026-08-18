# Programação Orientada a Objetos (POO)

É uma técnica de programação, uma maneira de fazer, o principal conceito de POO são Classes e Objetos, onde classes são representações de algo do mundo real e objetos são representações das classes, seguem exatamente o modelo definido nela.

 É composta por quatro pilares:
- Abstração
- Encapsulamento
- Herança
- Polimorfismo

### Abstração
Abstrair um objeto do mundo real para um contexto específico considerando apenas os atributos importantes.

### Encapsulamento
Proteger uma classe e definir limites para alteração de suas propriedades, serve para ocultar seu comportamento e expor só o necessário.

### Herança
Permite reutilizar atributos, métodos e comportamentos de outra classe, serve para agrupar objetos parecidos mas com algumas característicias parecidas.
No C# não é permitida herança múltipla simultânea, apenas herança em "cascata", por mais que não seja recomendado.

### Polimorfismo
Podemos sobrescrever métodos das classes filhas para que o componente se comporte de forma diferente e tenha sua própria implementação. Com isso um mesmo método pode assumir diversas formas.

### Classe abstrata
Uma classe que não pode ser instanciada, ela serve exclusivamente como um modelo para ser herdado, com ela você pode implementar métodos e deixá-los a cargo de quem herdar

### Classe selada
É uma classe que nenhuma outra pode herdar dela, ou seja, "não pode ter filhos", como se fosse um ponto final na herança, para impedir uma cascata

### Classe object no C#
Essa classe é a mãe de todas as classes na hierarquia do .NET, todas elas derivam direta ou indiretamente da Object, ela tem o objetivo de prover serviços de baixo nível para suas classes filhas

### Interface
Parecido com uma classe abstrata, é um contrato que pode ser implementado por uma classe, pode definir métodos abstratos e não pode ser instanciada.
No C# não podemos ter herança múltipla com classes comuns, mas com interfaces podemos fazer implementações múltiplas para N classes.
 