# CLI Commands REST API (ASP.NET Core MVC)

With the plethora of CLI commands to learn, it is helpful to have an API that returns us commands that we often forget. This Commands API stores command line snippets along with a short description of what it does, as well as which platform it's for.

## The purpose of this project is to learn and practice concepts related to:
* Building a REST API
* .NET Core
* MVC Architectural Pattern
* C#
  
## More specifically, I used the following:
* Dependency injection
* Repository design pattern
* SQL Server Express & SSMS
* Entity Framework Core O/RM (DBContext, Migration)
* Data Transfer Objects (DTOs) & AutoMapper
* RESTful API guidelines
* HTTP (GET, POST, PUT, PATCH, DELETE, status codes)
* Views (Razor, Shared Layout, ViewBag, RenderSection)
* Testing API Endpoints (SwaggerUI & Postman)
* Currently working on Docker (Container, Image, Deploying on Docker Hub)
* Currently working on Microsoft Azure (Deployment: Docker Image + SQL Database)

## Application Architecture:
![RestAPIArchitecture](https://github.com/clarissacheng/CLICommandsRestAPI/assets/112114163/c75d4a7e-3262-4d57-9e68-10b48bece639)

## API Endpoints (CRUD):
![RestAPIEndPoints](https://github.com/clarissacheng/CLICommandsRestAPI/assets/112114163/99dc8362-0dc9-4c24-bbd1-49552c154f93)

## Sample endpoints using Postman:

### [HttpPost] Creates a new command, returns Location header with link to resource, as well as the '201 Created' status code
![RestAPIPost](https://github.com/clarissacheng/CLICommandsRestAPI/assets/112114163/76281182-418e-4a5a-aea1-fb1bf4cc78ca)

### [HttpPatch] Updates the value of the howTo attribute and returns the '204 No Content' status code.
![RestAPIPatch](https://github.com/clarissacheng/CLICommandsRestAPI/assets/112114163/a49deb6b-ec48-4c3d-b5e6-d7dcbd06deb7)

### [HttpGet] Gets all the current commands, displaying previous Post and Patch endpoints
![RestAPIGet](https://github.com/clarissacheng/CLICommandsRestAPI/assets/112114163/ce155a43-1317-49a0-802b-1e85ef445ee1)
