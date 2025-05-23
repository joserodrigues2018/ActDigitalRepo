Configurar o Migrations EF para usar no projeto

entity framework no projeto Ambev.DeveloperEvaluation.ORM

executar os comandos via terminal no diretorio onde ficam os migrations

dotnet tool list -g

-->> caso não esteja instalado
dotnet tool install --global dotnet-ef --version 5.0.2

 -->> caso deseje desistalar
dotnet tool uninstall -g dotnet-ef

-->> Excutar comando dentro do ditorio do projeto pasta src
-->> Este comando vai atualizar as tabelas baseadas nas models do Entity Framework para o Banco de Dados

dotnet ef database update -p .\Ambev.DeveloperEvaluation.ORM -s .\Ambev.DeveloperEvaluation.WebApi -v
