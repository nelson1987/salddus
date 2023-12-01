# salddus
Criação de aplicação de conta corrente






```sh
mkdir projetolinux
cd projetolinux
code .
dotnet new sln --name Salddus
dotnet new webapi -minimal --name FilmesApi
dotnet new web --name FilmesApi (se for utilizar minimalApi)
dotnet run --project FilmesApi/FilmesApi.csproj dev-certs https --trust
dotnet new gitignore
```

```sh
dotnet new xunit -o ProjetoTeste.Tests
dotnet sln add ./ProjetoTeste.Tests/ProjetoTeste.Tests.csproj
dotnet add ./Alura.Estacionamento.Tests/Alura.Estacionamento.Tests.csproj reference ./Alura.Estacionamento/Alura.Estacionamento.csproj 
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.10
```

```sh
git add .
git commit -m "menssagem do commit"
git push
```

# bibliography
https://balta.io/blog/aspnet-minimal-apis
https://microsoft.github.io/workshop-library/full/intro-minapi/
https://www.moesif.com/blog/technical/api-development/Building-Minimal-API-with-Dotnet/
https://andrewlock.net/exploring-the-dotnet-8-preview-exploring-the-new-minimal-api-source-generator/
'