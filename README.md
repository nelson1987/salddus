# salddus
Criação de aplicação de conta corrente

'
mkdir projetolinux
cd projetolinux
code .
dotnet new sln --name Salddus
dotnet new webapi --name FilmesApi
dotnet new web --name FilmesApi (se for utilizar minimalApi)
dotnet run --project FilmesApi/FilmesApi.csproj dev-certs https --trust
dotnet new gitignore

dotnet new xunit -o ProjetoTeste.Tests
dotnet sln add ./ProjetoTeste.Tests/ProjetoTeste.Tests.csproj
dotnet add ./Alura.Estacionamento.Tests/Alura.Estacionamento.Tests.csproj reference ./Alura.Estacionamento/Alura.Estacionamento.csproj 
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.10

git add .
git commit -m "menssagem do commit"
git push
'