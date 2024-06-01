<p align="center">
  <a href="" rel="noopener">
 <img src="./Img/banner.png" alt="Project logo"></a>
</p>
<h3 align="center">Address Management System</h3>

<div align="center">

![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927)
![.Net](https://img.shields.io/badge/.NET-5C2D91)
![C#](https://img.shields.io/badge/c%23-%23239120.svg)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg)

</div>

---

<p align="center"> Address management system where user can edit, list, add and delete, can also export as CSV.
    <br>
</p>

## 📝 Table of Contents

- [📝 Table of Contents](#-table-of-contents)
- [💡 System Requirements ](#-system-requirements-)
- [⛓️ Dependencies / Limitations ](#️-dependencies--limitations-)
- [🏁 Getting Started ](#-getting-started-)
  - [Run Project](#run-project)
- [🎈 Usage ](#-usage-)
- [⛏️ Built With ](#️-built-with-)
- [✍️ Authors ](#️-authors-)

## 💡 System Requirements <a name = "idea"></a>

Login screen:
- [x] User authentication.
- [x] Validation of credentials.
- [x] Redirection to home page after successful login.

Adreess scree:
- [x] Allow the user to add, view, edit and delete addresses.
- [x] Allow the user to export their saved addresses to a CSV file.

## ⛓️ Dependencies / Limitations <a name = "limitations"></a>

- Microsoft.EntityFrameworkCore and its dependencies to work with the database.
- Microsoft.EntityFrameworkCore.SqlServer to work with sql server.
- Newtonsoft.Json to convert json to string and string to json.

## 🏁 Getting Started <a name = "getting_started"></a>

It is necessary to have a .NET environment installed.

Upload the migrations to the database.
```bash
dotnet ef database update
```
Download dependencies
```bash
dotnet restore
```

### Run Project

```bash
dotnet run Program.cs

info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5242
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\your_installation_folder\address-management-system\AeCAddress
```


## 🎈 Usage <a name="usage"></a>

First create a user, go to the home screen, then you can go to addresses and do all the manipulation.

## ⛏️ Built With <a name = "tech_stack"></a>

- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) - Database
- [ASP NET](https://dotnet.microsoft.com/pt-br/apps/aspnet) - Server Framework
- [.NET](https://dotnet.microsoft.com/pt-br/) - Server Environment
- [C#](https://dotnet.microsoft.com/pt-br/languages/csharp) - Programming language

## ✍️ Authors <a name = "authors"></a>

- [@natancs](https://github.com/natancs) - Idea & Initial work

Thanks.
