# Aplicando os conceitos do clean code

# SOLID

## SRP - SINGLE RESPONSIBLITY PRINCIPLE - PRINCÍPIO DA RESPONSABILIDADE ÚNICA

    Uma terefa ou responsabilidade, deve ter apenas um motivo para ser alterada.

## OCP - OPEN-CLOSED PRINCIPLE - PRINCÍPIO ABERTO-FECHADO

Aberto para extensão, mas fechado para modificação, deve adicionar novas funcionalidades sem alterar o código existente.

Como usar?

- Usando interfaces e abstrações
- Padrão decorator
- Padrão Strategy
- Padrão Factory
- Injeção de dependêcia

## LSP - LISKOV SUBSTITUTION PRICIPLE - PRINCÍPIO DA SUBSTITUIÇÃO DE LISKOV

Objetos de uma classe derivada devem poder substituir objetos da classe base sem alterar o comportamento

## ISP - INTERFACE SEGREGATION PRINCIPLE - PRINCÍPIO DA SEGREGAÇÃO DE INTERFACES

Uma classe não dever ser forçada a implementar interfaces que não usa.

## DIP - DEPENDENCY INVERSION PRINCIPLE - PRINCÍPIO DA INVERSÃO DE DEPENDÊNCIA

Classes de alto nível não devem depender de classes de baixo nível, mas sim de abstrações(interfaces ou classes abstratas)

# Padrões de Projetos (Design Patterns)

## Padrão de projeto Decorator

O padrão de projeto Decorator é um padrão estrutural que permite adicionar comportamentos a um objeto de forma dinâmica, sem alterar sua estrutura original. Ele é especialmente útil quando você precisa estender a funcionalidade de objetos de maneira flexível e modular, evitando a criação de uma grande hierarquia de subclasses.

## Principais Características:

- Flexibilidade: Permite adicionar responsabilidades adicionais a um objeto em tempo de execução.

- Modularidade: Facilita a combinação de diferentes comportamentos sem alterar o código original do objeto.

- Alternativa às Subclasses: Evita a necessidade de criar múltiplas subclasses para cada combinação possível de comportamentos.

## Funcionamento:

- Supertipo Comum: Tanto o objeto original quanto os decoradores compartilham o mesmo supertipo.

- Encapsulamento: Decoradores encapsulam o objeto original, adicionando seu próprio comportamento antes ou depois de delegar a tarefa ao objeto decorado.

- Dinamismo: Objetos podem ser decorados a qualquer momento, permitindo a adição de múltiplos decoradores de forma dinâmica.

## Exemplo Prático:

Imagine uma lanchonete onde cada lanche pode ter versões normais, gourmet e veganas. Usando o padrão Decorator, você pode criar decoradores para adicionar características específicas a cada tipo de lanche sem precisar criar subclasses para cada combinação possível

## Padrão de projeto Strategy

O padrão de projeto Strategy é um padrão comportamental que permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. Isso permite que o algoritmo varie independentemente dos clientes que o utilizam.

## Principais Características:

- Encapsulamento de Algoritmos: Cada algoritmo é encapsulado em uma classe separada, permitindo que sejam trocados facilmente.

- Intercambiabilidade: Os algoritmos podem ser trocados em tempo de execução sem alterar o código do cliente.

- Flexibilidade: Facilita a adição de novos algoritmos sem modificar o código existente.

## Funcionamento:

- Contexto: A classe que utiliza o algoritmo (chamada de Contexto) mantém uma referência a um objeto Strategy.

- Strategy: Interface comum para todos os algoritmos.

- ConcreteStrategy: Implementações concretas da interface Strategy, cada uma representando um algoritmo específico.

## Exemplo Prático:

Imagine um aplicativo de navegação que pode calcular rotas usando diferentes estratégias, como a rota mais rápida, a rota mais curta ou a rota mais econômica. Usando o padrão Strategy, você pode criar uma interface RouteStrategy e classes concretas como FastestRoute, ShortestRoute e EconomicalRoute, permitindo que o usuário escolha a estratégia desejada sem alterar o código principal do aplicativo

## Padrão de projeto Factory

O padrão de projeto Factory é um padrão criacional que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados. Existem várias variações deste padrão, incluindo o Factory Method e o Abstract Factory.

## Principais Características:

- Encapsulamento da Criação de Objetos: A lógica de criação de objetos é encapsulada, permitindo que o código cliente não precise conhecer os detalhes de implementação.

- Redução de Acoplamento: O padrão ajuda a reduzir o acoplamento entre classes, tornando o código mais flexível e fácil de manter.

- Flexibilidade: Facilita a adição de novos tipos de objetos sem modificar o código existente.

## Funcionamento:

- Factory Method: Define um método que deve ser implementado pelas subclasses para criar objetos. A superclasse chama este método para criar um objeto, mas a decisão de qual objeto criar é delegada às subclasses.

- Abstract Factory: Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. É útil quando você precisa criar vários objetos relacionados que devem ser usados juntos.

## Exemplo Prático:

Imagine um sistema de gerenciamento de documentos onde você pode criar diferentes tipos de documentos, como PDFs, Word e Excel. Usando o padrão Factory, você pode criar uma interface DocumentFactory com métodos para criar esses documentos. As subclasses PDFDocumentFactory, WordDocumentFactory e ExcelDocumentFactory implementariam esses métodos para criar os tipos específicos de documentos

# Principais Pilares da POO

A Programação Orientada a Objetos (POO) é um paradigma de programação que organiza o software em torno de “objetos” em vez de funções e lógica. Esses objetos são instâncias de classes, que podem conter dados (atributos) e métodos (funções) que operam sobre esses dados.

## Principais Pilares da POO:

- Encapsulamento: Agrupa dados e métodos que operam sobre esses dados dentro de uma única unidade (classe), escondendo os detalhes internos e expondo apenas o necessário. Isso melhora a modularidade e a manutenção do código.

- Herança: Permite que uma classe (subclasse) herde atributos e métodos de outra classe (superclasse), promovendo a reutilização de código e a criação de hierarquias.

- Polimorfismo: Permite que diferentes classes sejam tratadas através da mesma interface. Métodos podem ser implementados de diferentes maneiras em classes diferentes, mas podem ser chamados de forma uniforme.

- Abstração: Foca nos aspectos essenciais de um objeto, ocultando os detalhes complexos. Isso permite que os programadores trabalhem com representações simplificadas de objetos, facilitando o desenvolvimento e a manutenção do sistema.

## Exemplo Prático:

Imagine um sistema de gerenciamento de veículos. Você pode ter uma classe Veiculo com atributos como marca e modelo, e métodos como acelerar e frear. Classes específicas como Carro e Moto podem herdar de Veiculo e adicionar seus próprios atributos e métodos específicos, como abrirPorta para Carro.

# Definição das interfaces usadas

## ICalculadoraDescontoPorFidelidade - Calcular o percentual do desconto com base na fidelidade

- Define um contrato para qualquer classe que implemente a lógica de cálculo de descontos com base na fidelidade do cliente.
- Isola a lógica de cálculo de descontos por fidelidade, tornando o código mais modular e fácil de manter.
- Cada aspecto da lógica de desconto (status da conta e fidelidade) é separado, seguindo o princípio da responsábilidade única.

## ICalculadoraDesconto - O papel dessa interface é facilitar a criação de diferentes estratégias de desconto. (Usando o Padrão Strategy)

- Define um contrato para qualquer classe que implemente a lógica de aplicar descontos.
- Adicionar novos tipos de descontos é simples, pois basta criar uma nova classe que implemente ICalculadoraDesconto.
- As alterações em uma estratégia de desconto não afetam outras partes do sistema.

## ICalculadoraDescontoStatusConta - Calcular o Preço depois do desconto com base no status da conta. (Usando o Padrão Factory)

- Define um contrato para a criação de objetos que calculam descontos com base no status da conta do cliente.
- Implementa o padrão de projeto Factory, permitindo a criação de objetos ICalculadoraDesconto com base em um critério (neste caso, o status da conta)
- Centraliza a lógica de criação das diferentes estratégias de desconto em um único lugar, promovendo a separação de responsabilidades.
- Facilita a adição de novos tipos de descontos com base no status da conta sem modificar a lógica existente.
