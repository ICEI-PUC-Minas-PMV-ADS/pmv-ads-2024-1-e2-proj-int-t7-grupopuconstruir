# Registro de Testes de Software

Teste #1, 12 Maio 2024

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, foi realizado o registro das evidências dos testes feitos na aplicação pela equipe. Para a Etapa 3, foram testados os requisitos RF-01 e RF-02. 

| **Caso de Teste** 	| CT-01 – Validar a inserção de dados para criação de uma conta / Cadastrar Perfil 	|
|:---:	|:---	|
|	Requisito Associado 	| RF-01 - <!-- A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. --> Criar e gerenciar dados de login |
| Registro de Evidência	| ![](img/Cadastro-PUConstruir.png) |
| Registro de Evidência | ![](img/Index-PUConstruir.png) |
| Critério de Êxito | Tela de mensagem "bem-vindo" é exibida. |

| **Caso de Teste**	| CT-02 – Efetuar login	|
|:---:	|:---	|
|	Requisito Associado 	| RF-01 - Criar e gerenciar dados de login |
| Registro de Evidência	| ![Tela de Login](img/Login-PUConstruir.png) |
| Registro de Evidência | ![Mensagem Login Inválido](img/LoginInvalido-PUConstruir.png) |
| Critério de Êxito | Dados incorretos de login cadastrado trazem a mensagem de login inválido. |

Para ambos CT-01 e CT-02, encontre aqui o vídeo-apresentação da Prova de Conceito da [Etapa 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/tree/main/docs/img/videoApresentacao_Etapa3.mp4)

---------------------------------------------------------------------------------------------------------------------------------

Teste #2, 04 Junho 2024

Para cada caso de teste definido no Plano de Testes de Software, foi realizado o registro das evidências dos testes feitos na aplicação pela equipe. Para a Etapa 4, foram testados todos os requisitos.

| **Caso de Teste**	| CT-01 – Validar a inserção de dados para criação de uma conta |
|:---:	|:---	|
|	Requisito Associado 	|RF-01 - Criar e gerenciar dados de login|
| Registro de Evidência	| ![tela cadastro - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/87528bc8-306e-40f1-8a52-d94f230083a2) |
| Critério de Êxito | Tela de mensagem "bem-vindo" é exibida. |

| **Caso de Teste**	| CT-02 – Efetuar login |
|:---:	|:---	|
|	Requisito Associado 	| Verificar se o usuário consegue logar-se na aplicação. |
| Registro de Evidência	| ![tela bem vindo - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/21cfb66d-8d65-487d-8982-3536dc5f602a)  |
| Critério de Êxito |Tela de mensagem "bem-vindo" é exibida.|

| **Caso de Teste**	| CT-03 – Recuperar senha de acesso	|
|:---:	|:---	|
|	Requisito Associado 	| RF-02 - O usuário deve conseguir recuperar senha |
| Registro de Evidência	| ![tela esqueci senha - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/d2ba17e3-a009-4144-a4e9-3cfb76e17391) |
| Registro de Evidência	| ![tela esqueci senha sucesso - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/89b893c4-d747-4bec-adfe-653f29f5fa0b) |
| Registro de Evidência	| ![email nova senha - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/a17041d8-fcf0-4152-9282-411533b5efeb) |
| Critério de Êxito | Foi enviado uma nova senha por email. |

| **Caso de Teste**	| CT-04 – Criar dados de materiais	|
|:---:	|:---	|
|	Requisito Associado 	| RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Registro de Evidência	|  ![tela materiais - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/29863afb-97e6-43a7-8ad2-09dec7467bce) |
| Registro de Evidência	| ![tela cadastro de material 1 - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/6fc37d8b-6025-4703-a0f7-f9780c5305f2)  |
| Registro de Evidência	| ![tela cadastro de materiais sucesso - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/7c368dfc-4e94-4fd8-a20c-6409e01d59f8) |
| Critério de Êxito |Novo material incluído com sucesso.|

| **Caso de Teste**	| CT-05 – Editar os dados de um material	|
|:---:	|:---	|
|	Requisito Associado 	| RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Registro de Evidência	| ![tela editar material  - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/5245fddc-492d-463f-8e35-d0d98b3f9153) |
| Registro de Evidência	| ![tela editar material sucesso - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/abe1b55f-2334-4ad1-9f60-36c20096037b)|
| Critério de Êxito |Novo material editado com sucesso.|

| **Caso de Teste**	| CT-06 – Excluir os dados de um material	|
|:---:	|:---	|
|	Requisito Associado 	| RF-03- A aplicação deve possuir a opção de criar e gerenciar dados dos materiais. |
| Registro de Evidência	| ![tela certeza excluir - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/da41db9f-779b-40bc-a99d-a3d1d69ed189) |
| Registro de Evidência	| ![tela material excluido - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/f9512482-032e-4a5a-9930-35a04d678f20) |
| Critério de Êxito |Novo material excluído com sucesso após confirmação no pop-up.|

| **Caso de Teste**	| CT-07 – Criar um serviço 	|
|:---:	|:---	|
|	Requisito Associado 	| | Registro de Evidência	| Verificar se o usuário consegue criar um serviço. | |
| Registro de Evidência	| ![tela serviços - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/d639afc3-c3a7-44dc-9705-d4c22d062f85) |
| Registro de Evidência	| ![tela preenchimento serviço - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/f10dfdf9-8f1f-4dc9-aeab-77e547b48bf7) |
| Registro de Evidência	| ![tela serviço sucesso - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/cb1b44d4-7f94-4f7f-a5eb-e9831629b774) |
| Critério de Êxito | Serviço criado com sucesso.|

| **Caso de Teste**	| CT-08 - Editar um serviço |
|:---:	|:---	|
|	Requisito Associado 	| | Registro de Evidência	| RF-04 - Criar e gerenciar dados dos serviço (prestados /de construção e reforma). | |
| Registro de Evidência	| ![tela editar serviço preenchimento - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/c1ec43b3-275e-4cf5-a85b-83dbe4514609) |
| Critério de Êxito | Serviço editado com sucesso.|

| **Caso de Teste**	| CT-09 – Excluir um serviço	|
|:---:	|:---	|
|	Requisito Associado 	| | Registro de Evidência	| RF-04 - Criar e gerenciar dados dos serviço (prestados /de construção e reforma). | |
| Registro de Evidência	| ![tela certeza excluir serviço - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/682a778e-f817-4455-aca0-5ad73ffbeb4e)  |
| Registro de Evidência	| ![tela serviço excluido - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/018a91bc-8679-4232-acb7-717d030441fa) |
| Critério de Êxito |Serviço excluído com sucesso.|

| **Caso de Teste**	| CT-10 – Criar um projeto	|
|:---:	|:---	|
|	Requisito Associado 	| | RF-05 - Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais).| |
| Registro de Evidência	| ![tela projeto - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/a2ef7998-1504-4176-b242-702f4ef29cb1) |
| Registro de Evidência	| ![tela projeto sucesso - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/f4cbc5d1-d20a-41d0-8c85-f5b90c8fbc5b) |
| Critério de Êxito |Projeto criado com sucesso.|

| **Caso de Teste**	| CT-11 - Editar um projeto	|
|:---:	|:---	|
|	Requisito Associado 	| | RF-05 - Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais).| |
| Registro de Evidência	| ![tela projeto editado - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/961cfc71-95f5-43c4-907e-e427e1156002) |
| Critério de Êxito |Projeto editado com sucesso.|

| **Caso de Teste**	|	CT-12 – Excluir um projeto	|
|:---:	|:---	|
|	Requisito Associado 	| | RF-05 - Criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais).| |
| Registro de Evidência	| ![tela certeza projeto - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/735f6573-c845-415b-abef-f8f492d2153c)|
| Registro de Evidência	| ![tela projeto excluido - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/414144bb-40d1-420c-b57e-c4f508e80f70) |
| Critério de Êxito |Projeto excluído com sucesso.|

| **Caso de Teste**	| CT-13 – Gerar um orçamento	|
|:---:	|:---	|
|	Requisito Associado 	| | RF-06 - Criar e gerenciar orçamentos (>1 projetos).| |
| Registro de Evidência	| ![tela criar orçamento - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/9a7e975b-f509-4a5a-bd32-35f7fab38298)|
| Registro de Evidência	| ![tela orçamento feito - puconstruir](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t7-grupopuconstruir/assets/145385547/ae713ea8-6073-430b-aa5b-79c90f859db2)|
| Critério de Êxito |Orçamento gerado com sucesso, porém sem pop-up.|

| **Caso de Teste**	|	CT-14 – Exportar um orçamento	|
|:---:	|:---	|
|	Requisito Associado 	| | RF-07 - (O usuário deve conseguir) exportar orçamentos nos formatos PDF. |
| Critério de Êxito |Sem êxito. Funcionalidade não configurada, não encontrada.|



A primeira fase de testes foi realizado dia 12 de Maio de 2024.
A segunda fase de testes foi realizado dia 04 de Junho de 2024.



## Avaliação

A aplicação é de fácil navegação, intuitiva, ainda em andamento de produção, faltaram alguns pop-ups previstos no plano de teste de Software, assim como a função de exportar orçamento. De modo geral, funcionando bem, sem bugs.

