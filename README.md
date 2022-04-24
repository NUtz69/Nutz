# Nutz

@ Nutz.Web

> 000 - Create Project

- Add -> Project -> ASP.Net Core Web App (Model-View-Controller) -> Nutz.Web
- Add -> Class Library -> Nutz.DataAccess 
- Add -> Class Library -> Nutz.Models 
- Add -> Class Library -> Nutz.Utility

- Nuget -> Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -> Install
- Nuget -> Microsoft.EntityFrameworkCore -> Install
- Nuget -> Microsoft.EntityFrameworkCore.Relational -> Install
- Nuget -> Microsoft.EntityFrameworkCore.SqlServer -> Install
- Nuget -> Microsoft.EntityFrameworkCore.Tools -> Install
- Nuget -> Microsoft.VisualStudio.Web.CodeGeneration.Design -> Install

- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 000 - Create Project
- Edit -> Class -> Nutz.Models -> Category.cs & ErrorViewModel.cs -> // 000 - Create Project
- Add -> Class -> Nutz.Utility -> SD.cs -> // 000 - Create Project

- Edit -> Nutz.Web -> Pages -> _ViewImports.cshtml -> @*000 - Create Project*@

- Edit -> Nutz.Web -> Program.cs -> // 000 - Create Project
- Edit -> Nutz.Web -> appsettings.json -> // 000 - Create Project
- Console -> Add-Migration AddCategoryToDb -> Update-Database

- Edit -> Nutz.Web -> Views -> Category -> c + d + e + i -> // 000 - Create Project
- Edit -> Nutz.Web -> Controllers -> CategoryController.cs -> // 000 - Create Project
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml & _Notification.cshtml -> @*000 - Create Project*@  

@ Nutz.DataAccess

> 001 - Repository Pattern

- Add -> Interface -> Nutz.DataAccess -> Respository -> IRespository -> IRespository.cs -> // 001 - Repository Pattern
- Add -> Class -> Nutz.DataAccess -> Respository -> Respository.cs -> // 001 - Repository Pattern
- Add -> Interface -> Nutz.DataAccess -> Respository -> IRespository -> ICategoryRespository.cs -> // 001 - Repository Pattern
- Add -> Class -> Nutz.DataAccess -> Respository -> CategoryRespository.cs -> // 001 - Repository Pattern
- Edit -> Nutz.Web -> Program.cs -> // 001 - Repository Pattern
- Edit -> Nutz.Web -> Controllers -> CategoryRespository.cs -> // 001 - Repository Pattern
