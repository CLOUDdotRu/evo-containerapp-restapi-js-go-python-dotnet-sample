# Быстрый старт

## Создание и публикация контейнера с REST API

1. Скачайте исходный код или клонируйте репозиторий
2. Перейдите в папку src: выполните команду в терминале cd ./restapi-python/src
3. Поменяйте порт в Dockerfile на  "--port", "8080". Так как Serveless Container может использовать только порт 8080
4. Соберите образ контейнера с тегом <URI container registry/evolution-restapi-python>
Обязательно указывайте linux/amd64 так как Serverless Containers поддерживают только данную архитектуру.
```
docker build --tag helloworld.cr.cloud.ru/evolution-restapi-python --platform linux/amd64 . 
```
5. Опубликуйте собранный образ в Evolution Container Registry

docker login URI container registry если не делали до этого
```
docker push helloworld.cr.cloud.ru/evolution-restapi-python"
```

## Настройка serverles container на обубликованный docker-image в container registry
1. Cоздайте Container Apps

2. Выберете образ из списка доступных (который создали в предыдущем разделе)

3. Опубликуйте контейнер



