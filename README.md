# dat250-blazor-evaluation

## Information
### Building an API
https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/4-aspnet-controllers

### Login
https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/standalone-with-authentication-library?view=aspnetcore-5.0&tabs=visual-studio


## Pros
- Built in support for dependancy injection
    - https://ardalis.com/new-is-glue/ 
## Cons

## Report

### Create blazor webassembly project hosted in ASP.NET

`dotnet new blazorwasm --hosted`

Creates a project with API and blazor frontend

### Add postgresql

Using standard postgresql database and opening port  5432

`docker run -p 5432:5432 --name some-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres`
![alt](Pictures\\AddService.PNG)
![alt](Pictures\\DbContext.PNG)


#### Creating the database and tables
- migrations from ef tools Ie. `add-migration mymigration` and `update-database`

#### Data transfer objects

Using automapper