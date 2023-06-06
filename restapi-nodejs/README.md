## Быстрый старт

Поменяйте порт в Dockerfile на EXPOSE 8080
```
FROM node:lts-alpine
ENV NODE_ENV=production
WORKDIR /usr/src/app
COPY ["package.json", "package-lock.json*", "npm-shrinkwrap.json*", "./"]
RUN npm install --production --silent && mv node_modules ../
COPY . .
EXPOSE 8080
RUN chown -R node /usr/src/app
USER node
CMD ["npm", "start"]
```
Соберите образ контейнера с тегом в формате REGISTRY_ID.cr.cloud.ru/REPOSITORY_NAME

Пример:
```docker build --tag "11111111-1111-1111-1111-11111111.cr.cloud.ru/backend-nodejs" --platform linux/amd64 . ```

Загрузите образ в реестр контейнеров

Пример:
```docker push "11111111-1111-1111-1111-11111111.cr.cloud.ru/backend-nodejs"```
