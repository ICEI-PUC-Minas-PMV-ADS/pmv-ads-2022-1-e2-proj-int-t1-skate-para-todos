# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários. 

## Personas

Amanda Lopes tem 37 anos, é psicóloga e dona de um pequeno consultório que atua atendendo crianças e jovens de baixa renda. 



## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários. 

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Amanda Lopes  | Solicitar doação de skate para crianças de baixa renda.            | Para inclusão da criança no esporte.               |
|Marcio/Toninho       | Doar alguma peça de skate usada.                | Ajudar pessoas a começar a praticar o esporte.  |
|Amanda Lopes|Manter comunicação com os doadores. |Combinar como será feita coleta das peças de skate. |
|Toninho Rauque |Solicitar peças de skate para outros jovens.  |Para completar um skate com as peças que a pessoa já possui.  |
|Victor Souza |Cadastrar mais de uma peça para doação.  |Poder atender várias pessoas ao mesmo tempo.  |
|Amanda Lopes |Poder acompanhar o andamento das doações solicitadas.  |Se organizar com os jovens assistidos. |
|Márcio Gomes |Conversar com quem está pedindo ou doando a peça  |Combinar forma de envio ou recebimento. |
|Victor Souza  |Saber a data que a solicitação de doação de peças foi criada.  |Priorizar os cadastros mais antigos.  |
|Toninho Rauque  |Compartilhar doação nas redes sociais.   |Pedir peças para mais pessoas.  |

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades de interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve permitir acesso apenas de pessoas que possuem login  | ALTA | 
|RF-002| O site deve apresentar ao usuário a possibilidade de doar peças    | ALTA |
|RF-003| O site deve permitir ao usuário visualizar e alterar o cadastro de solicitação de peças   | ALTA |
|RF-004| O site deve oferecer a opção de o usuário adicionar uma descrição junto com as peças solicitadas    | MÉDIA |
|RF-005| O site deve oferecer um canal de comunicação para o usuário que criou o pedido se comunicar com os outros    | ALTA |
|RF-006| O site deve permitir ao usuário realizar busca por localidades  | BAIXA |
|RF-007| O site deve permitir que o usuário tenha relatórios sobre seus pedidos cadastrados    | ALTA |
|RF-008| O site deve permitir que o usuário apague seus próprios comentários   | BAIXA |
|RF-009| O site deve permitir que o usuário que criou o cadastro apague comentários em seu pedido cadastrado  | BAIXA |
|RF-010| O site deve permitir que usuários selecionem mais de um tipo de peça para cada pessoa    | ALTA |
|RF-011| O site deve permitir que os usuários cadastrem mais de uma criança por vez    | ALTA |
|RF-012| O site deve permitir que usuários selecionem mais de uma pessoa para doar.    | ALTA |
|RF-013| O site deve possuir endereço único para cada solicitação de doação.    | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização um celular de forma adequada  |  ALTA | 
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade   |  MÉDIA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge)  |  ALTA | 
|RNF-005| Acesso simultâneo de usuários distintos  |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de  26/06/2022.  |
|02| O aplicativo deve salvar dados em bancos de dados.     |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho.     |

## Diagrama de Casos de Uso

INSERIR IMAGEM????
