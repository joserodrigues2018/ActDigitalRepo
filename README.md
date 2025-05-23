Projeto Teste Técnico para ActDigital

Escopo: Desenvolvimento de um Projeto Back-End Web Api para atender ao Carrinho de Compras On-Line para --> Vendas

Este Projeto WebApi RestFull tem a finalidade de controlar as vendas dos produtos no carrinho de compras On-Line com as 
opções de (CRUD ) Criar, Listar, Editar e Deletar para gerar uma venda aplicando as regras de negocios abaixo:
->> Limite de compra de 20 itens do mesmo produto
->> Aplicar regra de descontos no valor do mesmo produto pela quantidade: 
    Entre 5 a 9 itens - 10% de desconto
    Entre 10 a 20 itens - 20% de desconto
    Quantidades menores que 5 unidades do mesmo produto não tem desconto == 0%

Esse projeto foi desenvolvido em C#.Net no Visual Studio Community 2022
Seguindo as documentações para usar a Api para ser executada no Container em Linux no WSL2
Banco de dados PostgreSQL também instalado no container

Documentos na pasta docsConfigWebApi que está no projeto e versionado no Git
para ajudar na instalação, execução e testes da Api pelo Swagger ou Postman

-->> Checlist da documentação e passos para instalação do ambiente:
1.Configurar Ambiente do Projeto
2.Instalar o WSL2 (Windows System Linux)
3.Instalar a Distro Ubuntu do Linux no WSL2
4.Instalar o Docker Desktop no Windows
5.Instalar a Imagem do PostgreSQL no Docker Desktop
6.Baixar ou Clonar o Projeto do GitHub
7.Configurar o EntityFramework e o Migrations para o projeto
9.Executar o procedimento de Build e Publicação para criar a imagem e o container no Docker
10.Executar os testes pelo Swagger ou Postman dos EndPoints do porjeto
11.Tecnologias Utilizadas no Projeto
12.Prints com as imagens para ajudar na instalação do ambiente
13.Diagrama de Classes do Projeto
14.Diagrama DER - Entidade Relacionamento das tabelas
