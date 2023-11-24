### Comandos DDL SQL Server

1. **Tabela de Usuário**

```sql
CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Senha NVARCHAR(255) NOT NULL
);
```

2. **Tabela de Registros**

```sql
CREATE TABLE Registro (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DataDoRegistro DATETIME NOT NULL,
    ImagemDoRegistro NVARCHAR(MAX),
    IdDoUsuario INT FOREIGN KEY REFERENCES Usuario(Id)
);
```

3. **Tabela de AtividadeFísica**

```sql
CREATE TABLE AtividadeFisica (
    Id INT PRIMARY KEY FOREIGN KEY REFERENCES Registro(Id),
    NomeDaAtividade NVARCHAR(255),
    TipoDaAtividade NVARCHAR(255),
    Intensidade INT CHECK (Intensidade >= 1 AND Intensidade <= 10),
    Observacao NVARCHAR(MAX)
);
```

4. **Tabela de Alimentação**

Primeiro, criaremos um tipo ENUM para `TipoDeRefeicao`.

```sql
CREATE TYPE TipoDeRefeicao AS ENUM ('Desjejum', 'Almoço', 'Jantar');
```

Depois, a tabela de Alimentação:

```sql
CREATE TABLE Alimentacao (
    Id INT PRIMARY KEY FOREIGN KEY REFERENCES Registro(Id),
    TipoDeRefeicao TipoDeRefeicao,
    DescricaoDaRefeicao NVARCHAR(MAX),
    Horario DATETIME,
    RefeicaoDoLixo BIT
);
```

### Detalhamento

1. **Tabela de Usuário**: Define um `Id` como chave primária e auto-incrementada. Também garante que o e-mail seja único.
2. **Tabela de Registro**: Define um `Id` como chave primária e um `IdDoUsuario` como chave estrangeira que referencia a tabela `Usuario`.
3. **Tabela de AtividadeFísica**: Utiliza o `Id` do `Registro` como sua chave primária e estrangeira, seguindo o conceito de disjunção.
4. **Tabela de Alimentação**: Similar à tabela `AtividadeFisica`, também segue o conceito de disjunção.

### Pontos Importantes

- **Check Constraint**: O comando `CHECK` na coluna `Intensidade` da tabela `AtividadeFisica` garante que a intensidade estará entre 1 e 10.
- **ENUM**: SQL Server não suporta nativamente o tipo ENUM. Uma tabela de referência ou um CHECK constraint podem ser usados como alternativas.
- **Relacionamento 1-N**: O relacionamento entre `Usuario` e `Registro` é 1 para N através da chave estrangeira `IdDoUsuario`.

### Considerações

Você pode querer usar mecanismos de gatilho (`TRIGGER`) para garantir que cada registro tenha apenas uma atividade física ou uma alimentação, mas não ambas. Isso irá lidar com o conceito de disjunção completa entre as tabelas `AtividadeFisica` e `Alimentacao`.

Eu recomendaria revisar essas tabelas com outros membros da sua equipe, principalmente aqueles com mais experiência em design de banco de dados, para garantir que elas atendem aos requisitos e regras de negócio.
