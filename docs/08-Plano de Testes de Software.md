# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="02-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="03-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-00 |
|**Entrada** | Cadastro: Após preencher o e-mail, senha, telefone. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login e cadastro. Permitir o cadastro do usuário que deseja doar, solicitar uma doação ou ser listado como um dos destinatários das doações.  |
|**Passos** | 1º - Acessar o Navegador, 2º - Informar o endereço do site, 3º - Clicar no botão “Cadastre-se”, 4º - Preencher os campos com informações válidas, 5º - Clicar no botão “Cadastrar”. |
|**Critérios de Êxito** | "Cadastro concluído! Seja bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - O site deve permitir acesso apenas de pessoas que possuem login. |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1º - Acessar o Navegador, 2º - Informar o endereço do site, 3º - Clicar no botão no canto superior de login, 4º - Preencher os campos com informações válidas, 5º - Clicar no botão "Login". |
|**Critérios de Êxito** | O usuário será direcionado à homepage e terá acesso ao menu. |

|Caso de Teste |CT-03 – Alterar Senha |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-00 |
|**Entrada** | Após clicar no botão "esqueci minha senha", o usuário deverá informar o email cadastrado. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente.  |
|**Passos** | 1º - Acessar o Navegador,  2º - Informar o endereço do Site,  3º - Visualizar a página de login,  4º - Esqueci senha, 5º - Informar o email onde será enviado um link para a nova senha. 5º - Inserir uma nova senha no campo “senha” e no campo “confirme sua senha” redigite a senha e clique no botão “próximo” que levará para a próxima tela. |
|**Critérios de Êxito** | Senha alterada com sucesso. |

|Caso de Teste |CT-04 – Cadastro de peça para doação |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O site deve apresentar ao usuário a possibilidade de doar peças. |
|**Entrada** |  |
|**Objetivo do Teste** | Permitir ao usuário a opção de solicitar a coleta, |
|**Passos** |   |
|**Critérios de Êxito** |   |

|Caso de Teste |CT-05 – Cadastro de solicitação de doação |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - O site deve permitir ao usuário visualizar e alterar o cadastro de solicitação de peças. RF-004 - O site deve oferecer a opção de o usuário adicionar uma descrição junto com as peças solicitadas. RF-013 - O site deve possuir endereço único para cada solicitação de doação. |
|**Entrada** | O usuário irá preencher um formulário contendo dados como nome da peça, tipo e quantidade desejada/necessária. O usuário poderá alterar os dados depois de feito o cadastro, assim como consultá-los e adicionar uma descrição. |
|**Objetivo do Teste** | Permitir ao usuário realizar a solicitação de uma doação, assim como o cadastro dos itens que desejar receber e outras funções relacionadas à administração dessa solicitação, como visualizar ou alterar. |
|**Passos** | 1º - Acessar o navegador, 2º - Acessar a plataforma, 3º - Realizar o login, 4º - Escolher a opção desejada (Solicitar doação), 5º - Preencher formulário com as informações da peça necessitada. 6º - Acompanhar o andamento da solicitação. |
|**Critérios de Êxito** | "Solicitação concluída". Visualizar se o pedido consta no "Histórico de Solicitações". |

|Caso de Teste |CT-06 – Cadastro de criança que receberá doação  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-011 - O site deve permitir que os usuários cadastrem mais de uma criança por vez |
|**Entrada** | O usuário irá preencher um formulário com o objetivo de incluir uma criança para receber a doação. O formulário contém dados como nome, idade, como entrar em contato. O usuário poderá consultar os dados inseridos, assim como cadastrar várias crianças em uma só solicitação. |
|**Objetivo do Teste** | Permitir ao usuário cadastrar os dados de crianças que irão receber as doações do projeto. |
|**Passos** | 1º - Acessar o navegador, 2º - Acessar a plataforma, 3º - Realizar o login, 4º - Escolher a opção desejada (Cadastrar criança), 5º - Preencher formulário com as informações da criança. 6º - Acompanhar o andamento da solicitação. |
|**Critérios de Êxito** | "Solicitação concluída". Visualizar se o cadastro consta no "Lista de Donatários".  |

|Caso de Teste |CT-07 – Doar |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-002 - O site deve apresentar ao usuário a possibilidade de doar peças. RF-0010 - O site deve permitir que usuários selecionem mais de um tipo de peça para cada pessoa. RF012 - O site deve permitir que usuários selecionem mais de uma pessoa para doar.  |
|**Entrada** | O usuário irá preencher um formulário com o objetivo de doar uma ou mais peças, para uma ou mais crianças. O usuário poderá consultar os dados inseridos, assim como doar mais de um tipo de peça diferente, não se limitando a selecionar apenas um destinatário por vez. |
|**Objetivo do Teste** | Permitir ao usuário doar peças. |
|**Passos** | 1º - Acessar o navegador, 2º - Acessar a plataforma, 3º - Realizar o login, 4º - Escolher a opção desejada (Fazer doação), 5º - Preencher formulário com as informações da doação, selecionar quem irá recebê-las. 6º - Acompanhar o andamento da solicitação. |
|**Critérios de Êxito** | "Solicitação concluída". Visualizar se a doação consta no "Lista de Doações Realizadas".  |  

|Caso de Teste |CT-08 – Visualizar status do pedido de doação |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-007 - O site deve permitir que o usuário tenha relatórios sobre seus pedidos cadastrados |
|**Entrada** |  |
|**Objetivo do Teste** |  |
|**Passos** |  |
|**Critérios de Êxito** |  | 

|Caso de Teste |CT-09 - Comunicar-se com doadores e usuários que fizeram solicitação de doação |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-005 - O site deve oferecer um canal de comunicação para o usuário que criou o pedido se comunicar com os outros |
|**Entrada** | Através do acesso ao site e, tendo seu cadastro concluído, o mesmo poderá interagir com outros usuários, sejam doadores ou donatários. |
|**Objetivo do Teste** | Permitir ao usuários se comunicarem através do canal de comunicação. |
|**Passos** | 1º - Acessar o navegador, 2º - Acessar a plataforma, 3º - Realizar o login, 4º - Escolher a opção desejada (Iniciar Chat), 5º - Selecionar pessoa com quem deseja interagir. 6º - Preencher campo de mensagem com o que deseja enviar. |
|**Critérios de Êxito** | "Mensagem enviada com sucesso, aguarde resposta!" | 
