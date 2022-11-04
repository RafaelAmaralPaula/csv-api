# App leitura de csv 

# Sobre o projeto

 - É um projeto referente ao desafio técnico para desenvolvedor backend organizado pela **HVEX**.
 
 - Consiste basicamente em um programa bem simples , faz leitura leitura de um arquivo csv
 
 - Salva no banco de dados
 
 - Endpoint que retorna todos esses dados
 

# Como testar

- Precisa ter instalado o **SDK .NET 6.0** 

- Fazer import do backend em uma determinada ide

- Executar primeiro backend

- Necessário ter banco MySQL rodando localmente

- E também criar uma banco de dados chamado **apicsv**

- As configurações referente conexão com banco de dados fica no arquivo chamado **appsettings.json** nos atributos chamado **MySqlConnection**

- Rodar comando chamado **dotnet ef database update**

# Endpoints disponíveis
  ### FindAll
  ```
  GET 
  http://localhost:yourport/temperatures
  ```
# Tecnologias utilizadas 
 
## Back-end 
- .NET 6.0
- EntityFrameworkCore.Tools
- MySQL
- Asp.net
- AutoMapper
- CsvHelper 
- Swashbuckle(Swagger Documentation API)
- Xunit

## Diagrama do projeto

- Diagrama das tabelas do banco
- Diagrama de classes do projeto

[Link dos diagramas](https://gitlab.com/RafaelAmaralPaula/csv-api/-/tree/main/Documentation)

# Enunciado do desafio
   - Implemente um backend campaz de ler um arquivo csv com alguns dados salvar no banco e disponibilizar esses dados em um endpoint
  
# Autor 
 
Rafael Amaral De Paula

LINKEDIN
-https://www.linkedin.com/in/rafael-amaral-449558148/

YOUTUBE
-https://www.youtube.com/channel/UC2QC0Jpjn1f0gHkk0TvvL_g

SITE
-https://rafaelamaralpaula.github.io/my-links/
