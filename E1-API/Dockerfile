#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["E1-API/E1-API.csproj", "E1-API/"]
RUN dotnet restore "E1-API/E1-API.csproj"
COPY . .
WORKDIR "/src/E1-API"
RUN dotnet build "E1-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "E1-API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "E1-API.dll"]