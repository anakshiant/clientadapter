FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["src/BRBMicroSites/BRBMicroSites.csproj", "src/BRBMicroSites/"]
COPY ["src/BRB.Resources/BRB.Resources.csproj", "src/BRB.Resources/"]
RUN dotnet restore "src/BRBMicroSites/BRBMicroSites.csproj"
COPY . .
WORKDIR "/src/src/BRBMicroSites"
RUN dotnet build "BRBMicroSites.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BRBMicroSites.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BRBMicroSites.dll"]