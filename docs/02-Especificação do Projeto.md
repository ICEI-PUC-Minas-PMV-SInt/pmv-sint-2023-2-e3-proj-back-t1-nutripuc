# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

## Personas


> ![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e3-proj-back-t1-nutripuc/blob/main/docs/img/3.IMAGEM.png?raw=true)

> ![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e3-proj-back-t1-nutripuc/blob/main/docs/img/4.IMAGEM.png?raw=true)


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE`     |PARA ... `MOTIVO/VALOR`                       |
|--------------------|----------------------------------------|----------------------------------------------|
| Anderson Lima      | Registrar minha alimentação            | Não esquecer de fazer nenhuma refeição       |
| Anderson Lima      | Registrar minha prática de atividade   | Me sentir motivado ao ver regularidade       |
| Ivan Piselli       | Manter o registro de atividade física  | Alcançar meu objetivo o de hipertrofia       |
| Ivan Piselli       | Ter uma rotina de alimentação saudável | Me alimentar adequadamente pré e pós treinos |



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicamos uma técnica de priorização de requisitos.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve possuir um sistema de cadastro / login                                   | ALTA  | 
|RF-002| O sistema deve possuir uma forma de recuperação de cadastro                             | BAIXA |
|RF-003| O sistema deve possibilitar o registro de atividades físicas                            | ALTA  | 
|RF-004| O registro de atividade física deve colher a categoria de exercício                     | MÉDIA |
|RF-005| O registro de atividade física de colher a data e a duração                             | MÉDIA | 
|RF-006| O registro de atividade física deve possibilitar inserir novas categorias de exercício  | BAIXA |
|RF-007| O sistema deve possibilitar o registro de alimentação                                   | ALTA  | 
|RF-008| O registro de alimentação deve possuir data e horário                                   | ALTA  |
|RF-009| O registro de alimentação deve possuir categoria                                        | MÉDIA | 
|RF-010| O registro de alimentação deve possibilitar entrar com uma imagem                       | MÉDIA |
|RF-011| O registro de alimentação deve possibilitar marcar a refeição como "refeição do lixo"   | BAIXA | 
|RF-012| O sistema deve possuir funcionalidade de notificação para realizar refeição e exercício | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O aplicativo deverá ser responsivo e se adaptar entre mobile (até 512 pixels) e web (acima de 512 pixels)  | ALTA | 
|RNF-002| A sincronização de dados entre os usuários deve ser de, no máximo, 60 segundos |  MÉDIA | 
|RNF-003| O sistema deve possuir uma interface de fácil compreensão, intuitiva, não necessitando um treinamento ou manual para sua utilização, de forma a atingir um Customer Effort Score entre 0 e 4 | BAIXA | 
|RNF-004| O sistema deverá possuir um NPS (Net Promoter Score) entre 75 e 100, considerado excelente, até alcançar seu milésimo cliente |  BAIXA | 
|RNF-005| O usuário não deve navegar mais de três vezes para acessar todas as funcionalidades que o sistema oferece | MÉDIA | 
|RNF-006| O sistema deve respeitar as demandas da LGPD | MÉDIA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 04/12/2023 |
|02| O aplicativo deve se restringir às tecnologias C# no Back-end |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho  |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

> ![image](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e3-proj-back-t1-nutripuc/blob/main/tmp/diagrama-de-uso-de-caso-nutripuc.png?raw=true)