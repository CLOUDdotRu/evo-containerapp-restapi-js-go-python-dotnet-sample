## Быстрый старт

Поменяйте порт в Dockerfile на EXPOSE 8080
```
# Dockerfile References: https://docs.docker.com/engine/reference/builder/

# Start from the latest golang base image
FROM golang:latest

# Set the Current Working Directory inside the container
WORKDIR /app

# Add files to app folder
ADD . /app

# Build the Go app
RUN go build -o main .

# Expose ports to the outside world
EXPOSE 8080

# Command to run the executable
CMD ["./main"]

```
Соберите образ контейнера с тегом в формате REGISTRY_ID.cr.cloud.ru/REPOSITORY_NAME

Пример:
```docker build --tag 11111111-1111-1111-1111-11111111.cr.cloud.ru/backend-go --platform linux/amd64 . ```

Загрузите образ в реестр контейнеров

Пример:
```docker push 11111111-1111-1111-1111-11111111.cr.cloud.ru/backend-go```
