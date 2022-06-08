# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="02-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="04-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-001** - O site deve permitir acesso apenas de pessoas que possuem login. |
|**Entrada** | Cadastro: Após preencher o nome, e-mail e criar senha. |
|**Objetivo do Teste** | Permitir o cadastro dos usuários que desejam solicitar ou realizar uma doação. A realização do cadastro permite e valida seu Login de acesso, os direcionando aos próximos passos. |
|**Passos** | 1º - Acessar o Navegador, 2º - Informar o endereço do site, 3º - Clicar no botão “Cadastre-se”, 4º - Preencher os campos com informações válidas, 5º - Clicar no botão “Cadastrar”. |
|**Critérios de Êxito** | "Cadastro concluído! Seja bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-001** - O site deve permitir acesso apenas de pessoas que possuem login. |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1º - Acessar o Navegador, 2º - Informar o endereço do site, 3º - Clicar no botão de login localizado no canto superior, 4º - Preencher os campos com informações válidas, 5º - Clicar no botão "Login", 6º - Abrir página inicial do usuário. |
|**Critérios de Êxito** | O usuário será direcionado à página inicial do usuário e terá acesso ao menu. |

|Caso de Teste |CT-03 – Alterar Senha |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | |
|**Entrada** | Após clicar no botão "esqueci minha senha", o usuário deverá informar o email cadastrado. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente.  |
|**Passos** | 1º - Acessar o Navegador,  2º - Informar o endereço do Site,  3º - Visualizar a página de login,  4º - Clicar no campo "Esqueci minha senha", 5º - Informar o email onde será enviado um link para a nova senha. 5º - Inserir uma nova senha no campo “Senha”, redigitar a senha  no campo “Confirme sua senha” e clicar no botão “Próximo”, que o levará para a próxima tela confirmando a alteração. |
|**Critérios de Êxito** | Senha alterada com sucesso. |

|Caso de Teste |CT-04 – Cadastro de criança que receberá doação  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-011** - O site deve permitir que os usuários cadastrem mais de uma criança por vez |
|**Entrada** | O usuário irá preencher um formulário com o objetivo de incluir uma criança para receber a doação. O formulário contém dados como nome, idade, peça desejada, endereço para recebimento e como entrar em contato. O usuário poderá consultar os dados inseridos assim como fazer alterações em caráter de correção ou atualização de informações. |
|**Objetivo do Teste** | Permitir ao usuário cadastrar os dados de crianças que irão receber as doações do projeto. |
|**Passos** | 1º - Acessar o navegador, 2º - Informar o endereço do site, 3º - Realizar o login, 4º - Acessar a página inicial do usuário, 5º - Escolher a opção desejada (Cadastrar criança), 6º - Abrir página de cadastro de criança, 7º - Preencher dados de cadastro da criança, 8º - Adicionar peças desejadas para a criança, 9º - Acompanhar o andamento da solicitação. |
|**Critérios de Êxito** | "Solicitação concluída".  |


|Caso de Teste |CT-05 – Doar |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-002** - O site deve apresentar ao usuário a possibilidade de doar peças. **RF-003** - O site deve permitir ao usuário visualizar e alterar o cadastro de solicitação de peças. **RF-004** - O site deve oferecer a opção de o usuário adicionar uma descrição junto com as peças solicitadas. **RF-0010** - O site deve permitir que usuários selecionem mais de um tipo de peça para cada pessoa. **RF012** - O site deve permitir que usuários selecionem mais de uma pessoa para doar. **RF-013** - O site deve possuir endereço único para cada solicitação de doação. |
|**Entrada** | O usuário abrirá a página que contêm a lista de pedidos, selecionar o pedido escolhido e em seguida abrir a página da doação selecionada. O usuário escolherá o item que deseja doar. O usuário poderá doar uma ou mais peças, para uma ou mais crianças. O usuário poderá consultar os dados inseridos, assim como doar mais de um tipo de peça diferente, não se limitando a selecionar apenas um destinatário por vez.  |
|**Objetivo do Teste** | Permitir que o usuário realize uma doação. |
|**Passos** | 1º - Acessar o navegador, 2º - Informar o endereço do site, 3º - Realizar o login, 4º - Acessar a página inicial do usuário,  5º - Escolher a opção desejada (Doar), 5º - Selecionar o pedido desejado, 6º - Abrir página da doação selecionada, 7º - Escolher o(s) item(ns) que deseja doar, 8º - Clicar no botão "Doar", 9º - Acompanhar o andamento da solicitação. |
|**Critérios de Êxito** | "Solicitação concluída". Visualizar se o cadastro consta na página "Lista de pedidos já cadastrados". |


|Caso de Teste |CT-06 – Visualizar status do pedido de doação e gerar relatórios|
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-007** - O site deve permitir que o usuário tenha relatórios sobre seus pedidos cadastrados |
|**Entrada** | O usuário abrirá a página inicial e selecionar a opção "Acompanhamento de cadastro", isso o redirecionará para a página de acompanhamento de cadastros e em seguida ele selecionará a opção "Gerar relatórios". Após clicar nessas opções, o usuário abrirá a página de relatórios. |
|**Objetivo do Teste** | Permitir que usuário gere relatórios de doação e os visualize.  |
|**Passos** | 1º - Acessar o navegador, 2º - Informar o endereço do site, 3º - Realizar o login, 4º - Acessar a página inicial do usuário, 5º - Escolher a opção desejada (Acompanhamento de cadastro), 6º - Abrir a página de acompanhamento de cadastros do usuário, 7º - Clicar na opção "Gerar relatórios", 8º - Abrir página de relátorios do usuário. |
|**Critérios de Êxito** | "Relatórios gerados com sucesso". | 


|Caso de Teste |CT-07 - Comunicar-se com doadores e usuários que fizeram solicitação de doação |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | **RF-005** - O site deve oferecer um canal de comunicação para o usuário que criou o pedido se comunicar com os outros |
|**Entrada** | Através do acesso ao site e, tendo seu cadastro concluído, o mesmo poderá interagir com outros usuários através da seção de comentários presente na página dos pedidos. |
|**Objetivo do Teste** | Permitir ao usuários se comunicarem ao fazer comentários na página do pedido escolhido. |
|**Passos** | 1º - Acessar o navegador, 2º - Acessar a plataforma, 3º - Realizar o login, 4º - Acessar a página inicial do usuário,  5º - Escolher a opção desejada (Doar), 6º - Abrir a lista de pedidos já cadastrados, 7º - Selecionar o pedido desejado, 8º - Clicar na opção "Excluir/Inserir comentários", 9º - Preencher o campo de mensagem com o que deseja inserir, 10º - Clicar no botão "Confirmar alterações". |
|**Critérios de Êxito** | O comentário entra na sequência dos existentes da página e a mesma é atualizada. | 
