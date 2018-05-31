FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Uni9.Oficinas.Api/Uni9.Oficinas.Api.csproj Uni9.Oficinas.Api/
RUN dotnet restore Uni9.Oficinas.Api/Uni9.Oficinas.Api.csproj
COPY . .
WORKDIR /src/Uni9.Oficinas.Api
RUN dotnet build Uni9.Oficinas.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Uni9.Oficinas.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Uni9.Oficinas.Api.dll"]
