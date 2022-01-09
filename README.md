# - Portal

- [Sobre](#sobre)
  - [Fotos do Projeto](#fotos-do-projeto)
- [Requisitos](#requisitos)
- [Configurações](#configurações)
    - [Git](#git)
    - [Banco de dados](#banco-de-dados)

## Sobre

Na empresa em que trabalhei chamada DDS, fiz esse projeto com finalidade em me ajudar com gerenciamento de retornos para os clientes e também aprimorar meus conhecimentos na linguagem de programação VB.Net.

## Fotos do Projeto

### Login
<img src="https://user-images.githubusercontent.com/44379238/85249183-718dd200-b429-11ea-93a1-96deeed83241.png" widht = 500 height = 300>

### Splash
<img src="https://user-images.githubusercontent.com/44379238/85249366-f4169180-b429-11ea-989e-bdc30737ae27.png" widht = 500 height = 300>

### Dashboard
<img src="https://user-images.githubusercontent.com/44379238/85249506-51124780-b42a-11ea-8ca7-a478548ec68f.png" widht = 500 height = 300>

### Adicionar
<img src="https://user-images.githubusercontent.com/44379238/85249509-52dc0b00-b42a-11ea-8596-b864e3a5be7b.png" widht = 500 height = 300>

## Requisitos

Para desenvolvimento e utilização do projeto são necessárias as seguintes dependências: 

- [Git](https://git-scm.com/): Disponibiliza o Git na máquina, incluindo o utilitário Git Bash, usado para executar os scrips do projeto  
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/): IDE Usada para desenvolvimento do projeto, com ferramentas necessárias para execução, build do *projeto*
- [MySql](https://www.mysql.com/downloads/): O banco de dados MySQL precisa ser instalado para rodar o banco de dados do projeto.

    
## Configurações

Essa seção detalha as configurações necessárias para criar um ambiente de desenvolvimento local.

### Git

Para clonar o projeto acesse a url **http://git.com.br**. Após **autenticação**, utilizando as credenciais de acesso utilize o comando abaixo:

Usando http:

```sh
git clone  gh repo clone ffresanto/sistema-retorno-vb
```

Após clonar o repositório, acesse a pasta do projeto e configure o usuário git com os seguintes comandos: 

```sh
$ git config --local user.name "<nome>"
$ git config --local user.email "<email gitlab>"
```

*Obs*.: Se o usuário git já foi configurado, desconsiderar esse passo.

### Banco de Dados

O backup do Banco de dados usado, vai estar na pasta do projeto com nome “backup 20200622 0132.sql”, precisara fazer a importação no MySql.

### Configurando Banco de Dados no Projeto

Dentro da classe "ConexãoVB.vb" precisara configurar com nome do banco, usuario e senha.

``` sh 
Public conexao As New MySqlConnection("Server=localhost;Port=3307;Database=db_nomebanco;Uid=seu_usuario;Pwd=sua_senha;")
```


