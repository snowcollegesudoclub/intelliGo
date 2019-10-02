FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["intelliGo/intelliGo.csproj", "intelliGo/"]
RUN dotnet restore "intelliGo/intelliGo.csproj"
COPY . .
WORKDIR "/src/intelliGo"
RUN dotnet build "intelliGo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "intelliGo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "intelliGo.dll"]