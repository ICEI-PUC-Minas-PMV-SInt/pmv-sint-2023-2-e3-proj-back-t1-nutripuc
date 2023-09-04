
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

 ![image]()

## Wireframes

São protótipos usados em design de interface para sugerir a estrutura de um site web e seu relacionamentos entre suas páginas. Um wireframe web é uma ilustração semelhante do layout de elementos fundamentais na interface.
 
 Tela – Homepage

A tela homepage é a tela de boas vindas da aplicação, onde é possível verificar um texto breve descritivo das funcionalidades que a aplicação oferece e onde possui um formulário de login com um botão no canto superior direito para cadastro.

Essa tela é formada por três componentes principais:

-	Componente de formulário de login permite ao usuário entrar na aplicação;
-	Componente de texto resume o que a aplicação oferece;
-	Componente de link de signup que dá acesso à página de cadastro

![image]()


Tela – Signup (Cadastro)

A tela de Signup (Cadastro) é a tela que realiza o cadastro de um novo usuário no sistema.
Essa tela é composta por três componentes principais:

-	Componente de formulário de signup permite captar um e-mail e uma senha com um campo extra de confirmação de senha;
-	Componente de botão de signup que finaliza o cadastro;
-	Componente de link de login que retorna à página principal.

![image]()


Tela – Dashboard

A tela de Dashboard é a tela que exibe as funcionalidades que o sistema oferece para o usuário. São essas funcionalidades: Calculadora de IMC, Histórico de Peso, Registro de Consumo de Agua, Diário de Alimentação, Registro de Atividade Física, Metas.

Essa tela é composta por oito componentes principais:

-	Componente de informação de cadastro que mostra o e-mail do usuário que está logado;
-	Componente de botão de logout que encerra a sessão do usuário e retorna para a página home;
-	Componente de card de Diário de Alimentação que encaminha o usuário para a tela desta funcionalidade.
-	Componente de card de Registro de Atividade Física que encaminha o usuário para a tela desta funcionalidade.

![image]()


Tela – Registro de Atividades Físicas

A tela de Registro de Atividades Físicas exibe um histórico com as atividades registradas pelo usuário em formato de tabela. Essas atividades podem ser inseridas antes ou depois de serem praticadas. E, para demonstrar isso, existe uma coluna chamada “Status”, que é inicializada como “Pendente”, e pode ser atualizada posteriormente para “Concluído”.

Essa tela é formada por dois componentes:

-	Componente Tabela de Registros de Atividades Físicas - Exibe o histórico das atividades contendo as colunas “Atividade”, “Data”, “Horário” e “Status”;
-	Componente Formulário de Nova Atividade Física - Adiciona uma nova atividade à tabela Registro de Atividades Físicas. Contém um formulário para preenchimento das informações “Atividade”, “Data” e “Horário”, que são adicionadas à tabela ao clicar em “Adicionar Atividade Física”.

![image]()


Tela – Diário de Alimentação

A tela de Diário alimentar permite com que o usuário visualize seu histórico de alimentação.

Essa tela é composta por três componentes principais:

-	Componente de diário de alimentação a data da refeição, o horário, o tipo de refeição e o texto da refeição que o usuário ingeriu;
-	Componente de botão de adicionar refeição abre o modal para registro;
-	Componente de registro de refeição é um modal que permite ao usuário selecionar o tipo de refeição e entrar com um texto descritivo do que ingeriu.

![image]()




