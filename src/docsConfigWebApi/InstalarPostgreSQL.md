Instalar o PostGreSQL no Docker Desktop 

Link com tutorial de ajuda -->>  https://www.dio.me/articles/executar-o-postgresql-no-docker-em-ambiente-windows

Passos abaixo para confiogurar PostGreSql no Docker via terminal

docker pull postgres:13 -->> baixar image postgreSql
docker images -->> ver imagens
docker start ambev_developer_evaluation_database -->> start container PostgreSQL
docker run --name ambev_developer_evaluation_database -p 5432:5432 -e POSTGRES_USER=developer -e POSTGRES_PASSWORD=ev@luAt10n -e POSTGRES_DB=developer_evaluation -d postgres:13

Informações importantes para configuração do Banco de Dados

ambev.developerevaluation.database:
    container_name: ambev_developer_evaluation_database
    image: postgres:13
    environment:
      POSTGRES_DB: developer_evaluation
      POSTGRES_USER: developer
      POSTGRES_PASSWORD: ev@luAt10n
    ports:
      - "5432"