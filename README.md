<h1 align="center">user-API</h1>

<h2>Contexto</h2>
Objetivo do projeto desenvolvido foi criar uma API de autenticação simples com os devidos teste end-to-end para garantir a integridade da aplicação. 

<h3>Desafios</h3>
<ul>
    <li>CRUD</li>
    <li>Testes de integração</li>
</ul>

<h3>Técnologias usadas</h3>

Desenvolvido usando: C#, xUnit (ferramenta de código aberto sob licença da Apache2 para criar testes de unidade), FluentAssertions (biblioteca com métodos e extensões para testes em ambiente .NET, ou seja, ajuda a escrever códigos melhores, legíveis e mais fáceis de entender e modificar), bibliotecas do entityFrameworkCore para a aplicação e para os testes e nos testes foi usado também o pacote do ASP.NET Core para teste de integração.

<h4>clone o repositório:</h4> 

```
git clone git@github.com:viniciusopassos/user-API.git
```

```
cd user-API
```

<h4>Instalando Dependências</h4>

```
cd src/	
```

```
dotnet restore
```

<h4>Executando aplicação</h4>
Para rodar a aplicação:

```
cd User-Api.Web
```

```
dotnet run
```


<h4>Executando Testes</h4>
Para rodar todos os testes:

```
cd User-Api.Test/
```

```
dotnet test
```
