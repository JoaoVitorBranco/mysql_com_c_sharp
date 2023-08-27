# Anotações

## Criação de uma [WEBAPI](https://dotnettutorials.net/lesson/creating-asp-net-core-web-api-project-using-net-core-cli/)

```console
$ dotnet new webapi –name MyFirstWebAPIProject
$ cd MyFirstWebAPIProject
$ dotnet build
$ dotnet watch run
```

- acessar: http://localhost:5007/swagger/index.html
- mesma docs utilizada pelo FASTAPI

## Ligando C# com MySQL

```console
$ dotnet add package MySql.Data
```
## Ligando o MySQL no [Visual Studio Code](https://www.geeksforgeeks.org/how-to-connect-to-mysql-server-using-vs-code-and-fix-errors/)


# Objetivo

Conseguir integrar C# com MySQL. Para tal, inicialmente, se tentará fazer uma API mockada em C#.