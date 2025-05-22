Instalar o PostGreSQL no Docker Desktop 

Link com tutorial de ajuda -->>  https://www.dio.me/articles/executar-o-postgresql-no-docker-em-ambiente-windows

Passos abaixo para confiogurar PostGreSql no Docker via terminal interno do Docker Desktop

docker pull postgres:13 -->> baixar image postgreSql
docker images -->> ver imagens
docker run --name ambev_developer_evaluation_database -p 5432:5432 -e POSTGRES_USER=developer -e POSTGRES_PASSWORD=ev@luAt10n -e POSTGRES_DB=developer_evaluation -d postgres:13
