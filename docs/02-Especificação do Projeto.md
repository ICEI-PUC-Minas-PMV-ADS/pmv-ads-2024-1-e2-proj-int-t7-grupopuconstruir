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

<!--Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja. -->

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
|RF-07| (O usuário deve conseguir) exportar orçamentos nos formatos PDF e xls(x) | BAIXA |

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

![Diagrama de Casos de Uso](img/diagramas/UseCaseDiagram_PUConstruir.jpg)

<!-- # Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)


# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

![Diagrama de rede simplificado notação francesa (método francês)](img/02-diagrama-rede-simplificado.png)

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.

![Gráfico de Gantt](img/02-grafico-gantt.png)-->

<!-- ## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados. 

![Simple Project Timeline](img/02-project-timeline.png)

## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

![Orçamento](img/02-orcamento.png)
-->
