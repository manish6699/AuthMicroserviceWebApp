FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["AuthMicroserviceWebApp/AuthMicroserviceWebApp.csproj", "AuthMicroserviceWebApp/"]
RUN dotnet restore "AuthMicroserviceWebApp/AuthMicroserviceWebApp.csproj"
COPY . .
WORKDIR "/src/AuthMicroserviceWebApp"
RUN dotnet build "AuthMicroserviceWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuthMicroserviceWebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuthMicroserviceWebApp.dll"]