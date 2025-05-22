Implantar projeto WebApi no Container

Acessar o pasta (\abi-gth-omnia-developer-evaluation 4 1template\backend ) ou a pasta antes
da pasta src onde está o arquivo Dockefile do projeto pelo Windows Explorer
e abrir um terminal Linux e executar os comando abaixo:

-->> Build e publish do projeto WebApi que vai criar uma imagem para o Docker Desktop
docker build --no-cache . -t ambevdeveloperevaluationwebapi

-->> Após o comando acima ser concluido executar o proximo comando que vai criar o container e configurar as portas de acesso para o Swagger da API
poder ser acessada -->> http://localhost:8080/swagger/index.html

docker run -p 8080:8081 -e ASPNETCORE_ENVIRONMENT=Development --name  ambev_developer_evaluation_webapi ambevdeveloperevaluationwebapi

