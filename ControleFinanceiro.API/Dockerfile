#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ControleFinanceiro.API/ControleFinanceiro.API.csproj", "ControleFinanceiro.API/"]
RUN dotnet restore "ControleFinanceiro.API/ControleFinanceiro.API.csproj"
COPY . .
WORKDIR "/src/ControleFinanceiro.API"
RUN dotnet build "ControleFinanceiro.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ControleFinanceiro.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ControleFinanceiro.API.dll"]