## Быстрый старт

Поменяйте порт в Dockerfile EXPOSE 8080
и ENV ASPNETCORE_URLS=http://+:8080

```
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "productapi_csharp.dll"]
```
Соберите образ контейнера с тегом в формате REGISTRY_ID.cr.cloud.ru/REPOSITORY_NAME

Пример:
```docker build --tag "helloworld.cr.cloud.ru/backend-dotnet" --platform linux/amd64 . ```

Загрузите образ в реестр контейнеров

Пример:
```docker push "helloworld.cr.cloud.ru/backend-dotnet"```
