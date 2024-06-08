# Especificações do Projeto

<!-- <span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto -->

## Personas

&emsp;Duas personas compõem o público-alvo:

### Persona 01
José Fonseca tem 37 anos e é um pedreiro autônomo. José nasceu em uma família de pequenos empreendedores do ramo de construção e tem o sonho de modernizar e expandir o negócio familiar. Gosta de estudar sobre novidades do ramo e de sair aos fins de semana. 

*Frustrações de José Fonseca incluem*:
- Reclamações constantes de clientes relacionados aos atrasos e gastos imprevistos. 
- Dificuldades na gestão de tempo, ocasionando a perda de clientes. 
- Arcar com prejuízos em serviços por empreitada.

*Motivações de José*:
- Ser mais assertivo no orçamento final.
- Otimizar tempo de entrega e custos dos serviços oferecidos. 
- Captar mais clientes.

*Aplicativos digitais utilizados*:
- Calculadora
- WhatsApp
- Facebook
- Tinder
- Zé Delivery 

### Persona 02
Karina Barbosa tem 48 anos e é enfermeira. Karina nasceu em cidade grande, é divorciada há 5 anos, mãe solteira, e é coordenadora do serviço de saúde da sua cidade. Gosta de pesquisar inspirações de decoração. Também gosta de assistir à programas de reformas de casa, como Irmãos à Obra. 

*Frustrações de Karina incluem*:
- Gastos imprevistos por orçamentos imprecisos feitos pelos profissionais em obras já realizadas. 
- Atrasos em obras por falta de recursos, devido a um planejamento financeiro ineficaz. 
- Falta de confiabilidade nos orçamentos recebidos anteriormente. 

*Motivações de Karina*:
- Ter um orçamento assertivo para reforma da área externa de sua residência. 
- Não exceder o orçamento previsto em suas obras.
- Gosta de constantemente fazer melhorias em sua residência.

*Aplicativos digitais utilizados por Karina*:
- Instagram
- Pinterest
- Tiktok
- WhatsApp

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Micro/Pequeno empreendedor no ramo da construção civil| Criar orçamentos mais precisos para meus clientes. |Diminuir a taxa de reclamações e perda de clientes, bem como reduzir os eventuais prejuízos em empreitadas|
|Dono de imóvel/Locatário|Realizar uma construção/reforma em minha residência, e necessito de um orçamento preciso| Um bom planejamento financeiro, evitando custos adicionais e eventuais atrasos na minha obra|

## Modelagem do Processo de Negócio 

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| Criar e gerenciar dados de login |ALTA| 
|RF-02| O usuário deve conseguir recuperar senha |ALTA|
|RF-03| (O usuário deve conseguir) criar e gerenciar dados dos materiais |ALTA|
|RF-04| (O usuário deve conseguir) criar e gerenciar dados dos serviço (prestados // de construção e reforma) | ALTA |
|RF-05| (O usuário deve conseguir) criar e gerenciar dados dos projetos (um ou mais serviços e/ou materiais) | ALTA |
|RF-06| (O usuário deve conseguir) criar e gerenciar orçamentos (um ou mais projetos) |ALTA|
|RF-07| (O usuário deve conseguir) exportar orçamentos nos formatos PDF | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| A aplicação deve ser responsiva para se adaptar a diversos tipos de dispositivo | ALTA | 
|RNF-02| A aplicação deve respeitar as regras da LGPD (Lei Geral de Proteção de Dados Pessoais) |  ALTA | 
|RNF-03| A aplicação deve permitir que o usuário aprenda a utilizar a aplicação de forma intuitiva |  MÉDIA | 
|RNF-04| A aplicação deve ser projetada de forma escalável, permitindo a adição de novos itens |  BAIXA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 23/06/2024 |
|02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend e no Entity Framework para backend |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

## Diagrama de Casos de Uso

&emsp;O diagrama de casos de uso pode ser encontrado abaixo:

![Diagrama de Casos de Uso](img/UseCaseDiagram_PUConsrtruir2.jpg)
