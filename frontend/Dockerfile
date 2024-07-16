FROM node:17-alpine as builder
WORKDIR /app

COPY package*.json .
CMD ["npm","install"] 
COPY . .

EXPOSE 3000
CMD ["npm","start"]

#Stage 2
#FROM nginx:1.19.0
#WORKDIR /usr/share/nginx/html
#RUN rm -rf ./*
#COPY --from=builder /app/build .
#ENTRYPOINT ["nginx", "-g", "daemon off;"]