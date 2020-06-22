# - Portal

- [Sobre](#sobre)
  - [Fotos do Projeto](#fotos-do-projeto)
- [Requisitos](#requisitos)
- [Configurações](#configurações)
    - [Git](#git)
    - [Banco de dados](#banco-de-dados)

## Sobre

O projeto tem como finalidade em fazer um sistema para gerenciamento de retornos para clientes e também para aprimorar conhecimentos sobre a linguagem de programação visual basic.

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
git clone  http://git.com.br/digital/est-.git
```

Utilizando ssh:

```sh
git clone git@git.com.br:-digitalweb.git
```

*Obs*: Para gerar a chave de ssh, abra o console git bash e execute o seguinte comando:

```sh
ssh-keygen -o -t rsa -b 4096 -C "informeseuemail@example.com"    
```
É possível no momento de gerar a chave, apresente algumas opções de configuração. Tecle **Enter** em todas.

```sh
Enter file in which to save the key (/c/Users/SEU-USUARIO-WINDOWS/.ssh/id_rsa ou c:\Users\SEU-USUARIO-WINDOWS\.ssh\id_rsa):
Enter passphrase (empty for no passphrase):
Enter same passphrase again:
```
Após gerar a chave, acesse a pasta .ssh em seu perfil de usuário (/c/Users/SEU-USUARIO-WINDOWS/.ssh ou c:\Users\SEU-USUARIO-WINDOWS\.ssh) através do proprio console do git bash e execute o comando **cat id_rsa.pub**. selecione toda a chave iniciando de ssh-rsa efetuando em seguida faça a cópia. Retorne ao gitlab e após autenticação, selecione seu perfil e clique em settings. Na opção do menu clique em **SSH Keys**, cole sua chave no textbox **key** e adicione.

```sh
**Exemplo** de chave gerada:

ssh-rsa /kOS32zefv8gH1XsSokAkOG++HnTry3oC0xdeB/zckVyDB4CfFZb0QFKfEVVoR308qofc9nrL6XogkpChrPOrNGRq0T69c3i9YGCkYYcH+r4AGXx9WPKfDHQgay+M25kFtBUDZxaJlp4xn1qDnS4+nEE/1KX8+x3Sr/1/kG+X+fMXSQZo6vzVkCqJT0P5QBzUArwGWyA4iF70cCM1O80fAZlFCZtIiGwr3pZcDqX9Ig6QBYHdlJnubXJJM4PEesu/+phf/XHgfmxDlAXLJAdCe0ibjz7a5KL/L4oORkIVGUDqvxJsrd2kLz/iPVtUlcMUvlmJL1Qy91xNTOoVViteG8wxLpAEJqe7fKP5GY2gm7qtU9LxGwn+8tha9zGoambvGZvGZYkSINSXO1reaVZRmeDvepbEc6C2IFCiNyVSgDLDphVhBAqHLQKFnZSqQ3oOItL+WZe2bMWh3TT4VQJYA8uUwh+TL8HqLXnVMFtq3SCn/olY+viCEJoXT4mCaeIttifAR2Ej647Z8fCzHkB6L5tXTtqb5XBGeqnQojYqcWPW22nmzgkdUtynwBapY9bx5uBRSMpCtbd+nuKVxMQ== informeseuemail@example.com
```


Após clonar o repositório, acesse a pasta do projeto e configure o usuário git com os seguintes comandos: 

```sh
$ git config --local user.name "<nome>"
$ git config --local user.email "<email gitlab>"
```

*Obs*.: Se o usuário git já foi configurado, desconsiderar esse passo.

### Configuração de parametros do projeto

A execução do projeto Portal depende de arquivos com perfis de configuração, de acordo com o ambiente para reprodução do projeto (*application.properties*).  

O perfil de execução do projeto utiliza parametros que devem ser passados para a JVM. Caso utilize A Ide Eclipse, Acesse a opção RUN no Menu da IDE. Logo em seguida, RUN CONFIGURATION, selecione Java Application, aba Arguments  e configure os parametros abaixo em **VM Arguments**.

``` sh 
-Dspring.config.location=C:\Users\SEU-USUARIO-WINDOWS\CAMINHO-DO-PROJETO\portal\properties\application.properties 
```


### Banco de Dados

Banco de dados usado, vai estar na pasta do projeto com nome “backup 20200622 0132.sql”, precisara fazer a importação no MySql.

Dentro da classe "ConexãoVB.vb" precisara configurar com nome do banco, usuario e senha.

``` sh 
Public conexao As New MySqlConnection("Server=localhost;Port=3307;Database=db_nomebanco;Uid=seu_usuario;Pwd=sua_senha;")
```


