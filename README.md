# MacBurgers

Aplicação web de uma lanchonete desenvolvida com ASP.NET Core MVC. O projeto apresenta um catálogo de lanches organizado por categorias, com persistência no PostgreSQL por meio do Entity Framework Core.

## Funcionalidades

- Página inicial com carousel de destaques.
- Listagem dos lanches cadastrados.
- Consulta de lanches e categorias por meio de repositórios.
- Persistência de dados com Entity Framework Core.
- Migrações para criação e preenchimento inicial do banco de dados.
- Interface responsiva baseada em Bootstrap.

## Tecnologias

- .NET 10
- ASP.NET Core MVC
- Entity Framework Core 10
- PostgreSQL
- Razor Views
- Bootstrap e jQuery

## Estrutura do projeto

```text
Context/        Contexto do Entity Framework Core
Controllers/    Controllers da aplicação MVC
Migrations/     Migrações e dados iniciais do banco
Models/         Entidades e modelos da aplicação
Repositories/   Interfaces e implementações de acesso a dados
ViewModels/     Modelos específicos das páginas
Views/          Páginas Razor
wwwroot/        CSS, JavaScript, imagens e bibliotecas do frontend
```

## Pré-requisitos

Para executar o projeto, instale:

- [.NET SDK 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server ou SQL Server Express
- Entity Framework Core CLI, caso ainda não esteja instalado

```powershell
dotnet tool install --global dotnet-ef
```

## Configuração

1. Clone o repositório e acesse sua pasta:

   ```powershell
   git clone <URL_DO_REPOSITORIO>
   cd macburgers-aspnet-core
   ```

2. Restaure as dependências:

   ```powershell
   dotnet restore
   ```

3. Crie um arquivo `appsettings.json` na raiz do projeto e configure a conexão com o SQL Server:

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=SEU_SERVIDOR;Database=MacBurgers;User Id=SEU_USUARIO;Password=SUA_SENHA;TrustServerCertificate=True;"
     },
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*"
   }
   ```

   O `appsettings.json` está no `.gitignore`. Não envie credenciais ou outras informações sensíveis para o repositório.

4. Aplique as migrações:

   ```powershell
   dotnet ef database update
   ```

## Execução

Inicie a aplicação com:

```powershell
dotnet run
```

O endereço local será exibido no terminal. As principais rotas são:

- `/` — página inicial.
- `/Lanche/List` — catálogo de lanches.

Para executar com recarregamento automático durante o desenvolvimento:

```powershell
dotnet watch run
```

## Próximos passos

- Filtrar os lanches por categoria.
- Implementar cadastro, edição e exclusão de produtos.
- Adicionar carrinho de compras.
- Criar autenticação e área administrativa.
- Adicionar testes automatizados.

## Segurança

Mantenha senhas, strings de conexão, certificados e demais segredos fora do controle de versão. Em ambientes compartilhados ou de produção, prefira variáveis de ambiente ou um gerenciador de segredos.
