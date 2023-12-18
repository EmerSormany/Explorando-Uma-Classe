# Explorando-Uma-Classe
Este repositório é um resumo da aula sobre classe do Bootcamp Decola Tech 2024 da DIO.me

## Explorando a classe em C# 

Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.

Ao criar uma propriedade em uma classe, você pode definir os métodos get e set, que são usados para obter e definir o valor da propriedade, respectivamente.

    Get: O método get é usado para recuperar o valor da propriedade. Quando você acessa a propriedade em seu código, o método get é chamado implicitamente para retornar o valor associado a essa propriedade.

    Set: O método set é usado para atribuir um valor à propriedade. Ele permite que você atribua um novo valor à propriedade quando a modifica.

É possível que uma propriedade tenha apenas get ou apenas set. Se não tiver nenhum dos dois, não é uma propriedade, e sim um campo.

## Como validar valores para as propriedades de acordo com a regra de negócio?

Na programação orientada a objetos, é uma prática comum usar validações para garantir que os valores atribuídos às propriedades estejam dentro de certos critérios ou padrões esperados. Isso pode ser feito dentro do método set de uma propriedade, no qual você pode usar estruturas de controle como o if para validar o valor recebido. Se o valor não estiver de acordo com a condição desejada, uma exceção do tipo ArgumentException será lançada, impedindo que um valor inválido seja armazenado na propriedade.

Em caso de validações simples, é possível usar o sinal de body expressions (=>), que é equivalente ao 'return'.

## O que significam as palavras public e private na definição das classes e propriedades?

Public significa que o campo em questão pode ser chamado e o seu valor consultado ou atribuído em qualquer momento dentro do código, e private significa o contrário: apenas a própria classe pode manipular o seu valor. Geralmente, essas características são utilizadas para criar um mecanismo de proteção para que os valores fornecidos pelo usuário atendam a determinadas condições implementadas pelo programador.

## Métodos

Um método é um bloco de código que contém uma série de instruções. São como ações que a classe vai realizar quando determinado método dela for chamado.

## Construtores

Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.

Por convenção, os construtores são os primeiro item da classe. O construtor precisa ter o mesmo nome da classe.

Quando um construtor é feito em uma classe, ele permite que os valores atribuídos às propriedades sejam feitos em uma única linha, como um argumento no momento em que está sendo criada uma instância daquela classe.

Dentro da classe, a sintaxe de um construtor é feita com a propriedade que se deseja ter o valor atribuído como argumento. Mas isso pode causar um problema, porque a partir de então o código vai exigir que, ao instanciar a classe, sejam passados obrigatoriamente os valores das propriedades. No entanto, não há limite de número de construtores; o programador pode criar um construtor recebendo os valores das propriedades como argumento e outro construtor sem receber nada. Isso dará a possibilidade de passar ou não valores no momento em que está sendo criada uma instância da classe.

Em caso de muitos parâmetros no construtor, é possível nomear cada parâmetro passando o nome do argumento, seguido de dois pontos, seguido do valor passado. Isso não influencia em termos de performance, mas ajuda a deixar o código mais legível.
