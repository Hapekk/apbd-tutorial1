FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Zajecia1/Zajecia1.csproj", "Zajecia1/"]
RUN dotnet restore "Zajecia1/Zajecia1.csproj"
COPY . .
WORKDIR "/src/Zajecia1"
RUN dotnet build "Zajecia1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zajecia1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zajecia1.dll"]
