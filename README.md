<p align="center">
  <a href="" rel="noopener">
 <img src="./Img/banner.png" alt="Project logo"></a>
</p>
<h3 align="center">Address Management System</h3>

<div align="center">

![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927)
![.Net](https://img.shields.io/badge/.NET-5C2D91)
![C#](https://img.shields.io/badge/c%23-%23239120.svg)
![Docker](https://img.shields.io/badge/docker-%230db7ed.svg)
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
  - [Login Screen](#login-screen)
  - [Create user screen](#create-user-screen)
  - [Address listing screen](#address-listing-screen)
  - [Create address screen](#create-address-screen)
  - [Edit address screen](#edit-address-screen)
  - [Delete address screen](#delete-address-screen)
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

You must have an environment with Docker compose installed.

In the project directory, run the container to use the application.

### Run Project

```bash
docker compose up --build -d
```

## 🎈 Usage <a name="usage"></a>

First create a user, go to the home screen, then you can go to addresses and do all the manipulation.

### Login Screen
![Login Screen](/Img/login.png)
### Create user screen
![Create user screen](/Img/create_user.png)
### Address listing screen
![Address listing screen](/Img/address_list.png)
### Create address screen
![Create address screen](/Img/create_address.png)
### Edit address screen
![Edit address screen](/Img/edit_address.png)
### Delete address screen
![Delete address screen](/Img/delete_address.png)

## ⛏️ Built With <a name = "tech_stack"></a>

- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) - Database
- [ASP NET](https://dotnet.microsoft.com/pt-br/apps/aspnet) - Server Framework
- [.NET](https://dotnet.microsoft.com/pt-br/) - Server Environment
- [C#](https://dotnet.microsoft.com/pt-br/languages/csharp) - Programming language
- [Docker](https://www.docker.com/) - Containerization

## ✍️ Authors <a name = "authors"></a>

- [@natancs](https://github.com/natancs) - Idea & Initial work

Thanks.
