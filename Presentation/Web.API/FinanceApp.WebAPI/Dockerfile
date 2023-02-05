#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Presentation/Web.API/FinanceApp.WebAPI/FinanceApp.WebAPI.csproj", "Presentation/Web.API/FinanceApp.WebAPI/"]
COPY ["Core/FinanceApp.Application/FinanceApp.Application.csproj", "Core/FinanceApp.Application/"]
COPY ["Core/FinanceApp.Domain/FinanceApp.Domain.csproj", "Core/FinanceApp.Domain/"]
COPY ["Infrastructure/FinanceApp.Infrastructure/FinanceApp.Infrastructure.csproj", "Infrastructure/FinanceApp.Infrastructure/"]
COPY ["Infrastructure/FinanceApp.Persistence/FinanceApp.Persistence.csproj", "Infrastructure/FinanceApp.Persistence/"]
RUN dotnet restore "Presentation/Web.API/FinanceApp.WebAPI/FinanceApp.WebAPI.csproj"
COPY . .
WORKDIR "/src/Presentation/Web.API/FinanceApp.WebAPI"
RUN dotnet build "FinanceApp.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinanceApp.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinanceApp.WebAPI.dll"]