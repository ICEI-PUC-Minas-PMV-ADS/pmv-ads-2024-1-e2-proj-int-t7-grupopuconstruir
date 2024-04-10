# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

&emsp;Aqui são apresentados os cenários de testes utilizados na aplicação para validação de satisfação dos requisitos funcionais.

<!-- Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". -->

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Validar a inserção de dados para criação de uma conta** 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-01 - <!-- A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. --> Criar e gerenciar dados de login |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar-se na aplicação. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de cadastro de usuário <br> 03-Inserir um nome válido no campo _Nome_. <br> 04-Inserir um endereço de e-mail no campo _e-mail_. <br> 05-Inserir caracteres da senha no campo _senha_.<br> 06-Clicar em _Cadastrar_. |
|Critério de Êxito | E-mail de confirmação recebido e mensagem "bem-vindo" na tela. |
|  	|  	|
| **Caso de Teste**	| **CT-02 – Efetuar login**	|
|	Requisito Associado 	| RF-01 - Criar e gerenciar dados de login |
| Objetivo do Teste 	| Verificar se o usuário consegue logar-se na aplicação. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de login _"Bem-vindo de volta"_ <br> 03-Inserir o e-mail já cadastrado no campo _email_. <br> 04-Inserir a senha cadastrada no campo _senha_.<br> 05-Clicar em _Entrar_. |
|Critério de Êxito | Login na aplicação e exibição da tela "Projetos" |
|  	|  	|
| **Caso de Teste**	| **CT-03 – Recuperar senha de acesso**	|
|Requisito Associado | RF-02	- O usuário deve conseguir recuperar senha |
| Objetivo do Teste 	| Verificar se o usuário consegue recuperar o acesso à aplicação após esquecer a senha. |
| Passos 	| 01-No acesso […], clicar em […] <br> 02-Acessar a página de login _"Bem-vindo de volta"_ <br> 03-Clicar em _Esqueci minha senha_ <br> 04-Digitar o e-mail cadastrado no campo _E-mail_ <br> 5-Clicar em _Enviar e-mail_ |
|Critério de Êxito | Receber a senha previamente cadastrada no e-mail cadastrado. |
|  	|  	|
| **Caso de Teste**	| **CT-04 – Criar dados de materiais**	|
|Requisito Associado | RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Materiais_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Materiais. <br> 07- No _Campo 1_ e _Campo 2_, inserir o nome do material e o preço, respectivamete. <br> 08-Clicar em _Cadastrar_. |
|Critério de Êxito | Material é criado e exibido na lista na tela de Materiais. |
|  	|  	|
| **Caso de Teste**	| **CT-05 – Editar os dados de um material**	|
|Requisito Associado | RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar os dados de um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Materiais_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Materiais. <br> 07- No _Campo 1_ e _Campo 2_, inserir o nome do material e o preço, respectivamete. <br> 08-Clicar em _Cadastrar_. <br> 09-Buscar o material cadastrado na lista de materiais, clicar no ícone _"lápis"_ para editar os dados do material. <br> 10-Alterar o nome do material para outro nome válido e preço, no _Campo 1_ e _Campo 2_, respectivamente. <br> 11- Clicar em _Salvar_. |
|Critério de Êxito | Nome e preço do material atualziados são exibidos na lista na tela de Materiais. |
|  	|  	|
| **Caso de Teste**	| **CT-06 – Excluir os dados de um material**	|
|Requisito Associado | RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir os dados de um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Materiais_ <br> 06-Buscar algum material previamente cadastrado na lista de materiais, clicar no ícone _"lixeira"_ para excluir os dados do material/o material. <br> 07-No pop-up de confirmação de exclusão do material, clicar em _Excluir_. |
|Critério de Êxito | Material deixa de ser exibido na lista de materiais. |
|  	|  	|
| **Caso de Teste**	| **CT-07 – Criar um serviço**	|
|Requisito Associado | RF-04	- Criar e gerenciar dados dos serviço (prestados /de construção e reforma). |
| Objetivo do Teste 	| Verificar se o usuário consegue criar um serviço. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Serviços_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Serviços. <br> 07- No _Campo 1_, inserir o nome do serviço. <br> 08-Clicar em _Cadastrar_. |
|Critério de Êxito | Um serviço é criado e exibido na lista da tela de Serviços. |
|  	|  	|
| **Caso de Teste**	| **CT-08 - Editar um serviço**	|
|Requisito Associado | RF-04	- Criar e gerenciar dados dos serviço (prestados /de construção e reforma). |
| Objetivo do Teste 	| Verificar se o usuário consegue editar os dados de um serviço. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Serviços_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de Serviços. <br> 07- No _Campo 1_, inserir o nome do serviço. <br> 08-Clicar em _Cadastrar_. <br> 09-Buscar o serviço cadastrado na lista de servios, clicar no ícone _"lápis"_ para editar os dados do serviço. <br> 10-Alterar o nome do serviço para outro nome válido no _Campo 1_. <br> 11- Clicar em _Salvar_. |
|Critério de Êxito | Nome do serviço é atualziado e é exibido na lista na tela de Projetos. |
|  	|  	|
| **Caso de Teste**	| **CT-09 – Excluir um serviço**	|
|Requisito Associado | RF-04	- Criar e gerenciar dados dos serviço (prestados /de construção e reforma). |
| Objetivo do Teste 	| | Objetivo do Teste 	| Verificar se o usuário consegue excluir os dados de um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Serviços_ <br> 06-Buscar algum serviço previamente cadastrado na lista de serviços, clicar no ícone _"lixeira"_ para excluir os dados do seerviço/o serviço. <br> 07-No pop-up de confirmação de exclusão do serviço, clicar em _Excluir_. |
|Critério de Êxito | Serviço deixa de ser exibido na lista de serviço. |
|  	|  	|
| **Caso de Teste**	| **CT-10 – Criar um projeto**	|
|Requisito Associado | RF-05	- Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais). |
| Objetivo do Teste 	| Verificar se o usuário consegue criar um projeto. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de projeto, clicar em _Projeto_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de projetos. <br> 07- Nos campos _Campo 1_, _Campo 2_, _Campo 3_ e _Campo 4_, inserir o nome do serviço e demais dados. <br> 08-Clicar em _Cadastrar_. |
|Critério de Êxito | Um projeto é criado e exibido na lista da tela de Projetos. |
|  	|  	|
| **Caso de Teste**	| **CT-11 - Editar um projeto**	|
|Requisito Associado | RF-05	- Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais). |
| Objetivo do Teste 	| Verificar se o usuário consegue editar os dados de um projeto. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Projetos_ <br> 06-Clicar sobre o ícone **+** no canto superior esquerdo da tela de projetos. <br> 07- Nos campos _Campo 1_, _Campo 2_, _Campo 3_ e _Campo 4_, inserir o nome do projeto e demais dados. <br> 08-Clicar em _Cadastrar_. <br> 09-Buscar o projeto cadastrado na lista de servi;os, clicar no ícone _"lápis"_ para editar os dados do serviço. <br> 10-Alterar o nome do serviço para outro nome válido no _Campo 1_. <br> 11- Clicar em _Salvar_. |
|Critério de Êxito | Nome do projeto é atualziado e é exibido na lista na tela de Projetos. |
|  	|  	|
| **Caso de Teste**	| **CT-12 – Excluir um projeto**	|
|Requisito Associado | RF-05	- Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais). |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir os dados de um material. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Projetos_ <br> 06-Buscar algum projeto previamente cadastrado na lista de projetos, clicar no ícone _"lixeira"_ para excluir os dados. <br> 07-No pop-up de confirmação de exclusão do projeto, clicar em _Excluir_. |
|Critério de Êxito | Projeto deixa de ser exibido na lista de serviço. |
|  	|  	|
| **Caso de Teste**	| **CT-13 – Gerar um orçamento**	|
|Requisito Associado | RF-06	- Criar e gerenciar orçamentos (>1 projetos). |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar um orçamento a partir dos projetos cadastrados. |
| Passos 	| 01-Acessar a página de login _"Bem-vindo de volta"_ <br> 02-Inserir o e-mail já cadastrado no campo _email_. <br> 03-Inserir a senha cadastrada no campo _senha_.<br> 04-Clicar em _Entrar_. <br> 05-Na coluna de opções da esquerda, na tela inicial de Projetos, clicar em _Orçamentos_ <br> 06-Informar a quantidade de projetos pertencentes ao orçamento no campo _Informe a quantidade_ <br> 07-Selecionar individualmente os projetos que farão parte do orçamento pelo menu dropdown de cada opção de projeto. <br> 08-Clicar em _Gerar orçamento_. <br> 09-IN PROGRESS |
|Critério de Êxito | IN PROGRESS |
|  	|  	|
| **Caso de Teste**	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
 
