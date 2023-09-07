# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Relação de Ambientes de Trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito deverá ser apresentada em uma tabela que especifica que detalha Ambiente, Plataforma e Link de Acesso.
Nota: Vide documento modelo do estudo de caso "Portal de Notícias" e defina também os ambientes e frameworks que serão utilizados no desenvolvimento de aplicações móveis.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software para deploy
- `dev`: versão de desenvolvimento do software onde as features serão "mergeadas"
- `feature\{nome}`: versão da funcionalidade que o desenvolvedor está trabalhando antes de ser "mergeada"

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto

### Divisão de Papéis

- Scrum Master: John Torres do Vale;
- Product Owner: Lucas Pedro Abreu;
- Equipe de Desenvolvimento: Lucas Pedro Abreu, João Pedro Leite Texeira, John Torres do Vale;
- Equipe de Design: Maria Paula Corrêa Mangabeira.

### Processo

Nossa equipe implementou uma versão adaptada do scrum às nossas necessidades acadêmicas. Para o gerenciamento do projeto, utilizamos a ferramenta GitHub Project que possui integração com o versionamento de código da equipe. Essa ferramenta permite criar milestones, issues e um dashboard aonde podemos vincular as issues a um usuário e a uma milestone.

Nós criamos, então, um milestone para cada etapa da disciplina "PROJETO: DESENVOLVIMENTO WEB BACK-END" e criamos issues com os entregáveis das respectivas etapas. Com isso, nossas sprints possuem a longevidade do milesone, ou seja, a duração até a data de entrega de cada etapa. Ao longo da sprint, acordamos de ter duas reuniões síncronas ao vivo, uma com nosso orientador Will Ricardo dos Santos Machado às terças-feiras 19h e outra exclusivamente entre à equipe às quintas-feiras 19h e quantos contatos assincronos forem necessários para manter o projeto dentro do cronograma preestabelecido.

### Ferramentas

As ferramentas empregadas no projeto são:

- Figma (https://www.figma.com)
  - Para wireframe, userflow e arquitetura da solução
- Lucid Chart App (https://lucid.app/lucidchart)
  - Para diagrama de uso de casos e diagrama de classes
- Microsoft Teams
  - Comunicação, Trabalho colaborativo e Troca de arquivos
- Git & Github
  - Versionamento de Código
  - Hospedagem de código e documentação
  - Github Project: Implementação do gerenciamento do projeto
- VSCode
  - Edição de código e integração com versionamento
