Classes
    Uma classe é uma estrutura de dados que combina estados (campos) e ações (métodos)

Objetos
    Objetos são instâncias de uma classe
    As classe suportam herança e polimorfismo, mecanmos pelos quais as classe deivadas podem estende especializar as classes base


    instâncias de classe (Objetos) são criadas usando o operados new, que aloca na memória para uma nova instância, chama de construtor para inicializar a instância e retorna uma a instância

    a memória ocupada por um objeto é recuperada automaricamente quando o obejto não está mais acessível. Não é necessariamente nem possível desalocar explicitamente Objetos em c#

    os membros de uma classe podem se estáticos ou membros da instância

    membros estaticos pertencem a classe e membros de instância pertencem ao objeto

    Constantes, variaves, métodos, propriedades, construtores, etc...

    Cada membro de uma classe tem uma acessibilidade associada, que controla as regiões do texto do programa que podem acessar o membro

    Podem ser: 
        public
        protected
        interal
        private

herança 
    Uma declaração de classe pode especficaar uma classe base, herdando os membros prublic, internal e protected ad classe base.
    Omitir uma especificação de classe base é o mesmo que derivar o tipo object
metodos

    um metodo é um mebro que implementa um computação ou ação que pode ser executada por um objeto ou classe
    os metodos podem ter uma lista de parametros, que representam valores ou referencias de variaveis passados para o metodo, e um tipo de retorno, que especifica o tpo de valor calculado e retornado pelo metodo.

structs
     Como as classe, as structs são estruturas de dados que podem conter membros de dados e membros de ação, mas, diferentmente das classses, as structs são tipos de valor e não requerem alocação de heap

        heap
        O Heap, ou área de alocação dinâmica, é um espaço reservado para variáveis e dados criados durante a execução do programa (runtime). Vamos dizer que o Heap é a memória global do programa.

        stack
        Já a pilha de funções (stack) é uma área da memória que aloca dados/variáveis ou ponteiros quando uma função é chamada e desalocada quando a função termina. Podemos dizer então que representa a memória local àquela função

    Uma variável de um tipo de struct armazena diretamente os dados da estrutura, enquanto uma varavel de um tipo de classe armazena uma instância a um objeto alocado na memória

    structs não aceitam herança determinada pelo desenvolvedor

    são uteis para pequenas estruturas de dados que possuem semêntica de valor: números complexos, pontos em um sstema de coordenadas ou pares de uma chave-valor em um dicionario são bons exemplos de utilização

    o uso de structs em vez de classe para pequenas estrutura de dados pode fazer uma grande diferença no numero de alozações na memoria

    