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

- Edit -> Nutz.Web -> Views -> Category -> c + d + e + i -> @*000 - Create Project*@
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

- Add -> Interface -> Nutz.DataAccess -> Respository -> IRespository -> IUnitOfWork.cs -> // 001 - Repository Pattern
- Add -> Class -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 001 - Repository Pattern

- Add -> Class -> Nutz.Models -> CoverType.cs -> // 001 - Repository Pattern
- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 001 - Repository Pattern
- Console -> Nutz.DataAccess -> Add-Migration AddCoverTypeToDb -> Update-Database

- Add -> Interface -> Nutz.DataAccess -> Respository -> IRespository -> ICoverTypeRespository.cs -> // 001 - Repository Pattern
- Add -> Class -> Nutz.DataAccess -> Respository -> CoverTypeRespository.cs -> // 001 - Repository Pattern
- Edit -> Interface -> Nutz.DataAccess -> Respository -> IRespository -> IUnitOfWork.cs -> // 001 - Repository Pattern
- Edit -> Class -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 001 - Repository Pattern

- Add -> Nutz.Web -> New Scaffolded Item -> MVC Area -> Admin
- Add -> Nutz.Web -> New Scaffolded Item -> MVC Area -> Customer
- Edit -> Nutz.Web -> Program.cs -> // 001 - Repository Pattern
- Copy -> Controllers + Views + _ViewImports.cshtml + _ViewStart.cshtm -> Nutz.Web -> Area -> Admin + Customer
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*001 - Repository Pattern*@ 
- Edit -> Nutz.Web -> Controllers -> CategoryRespository.cs -> // 001 - Repository Pattern
- Edit -> Nutz.Web -> Controllers -> HomeController.cs -> // 001 - Repository Pattern

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> CoverTypeController.cs -> // 001 - Repository Pattern
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> CoverType -> c + d + e + i -> @*001 - Repository Pattern*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*001 - Repository Pattern*@

@ Nutz.Models

> 002 - Product Management

- Edit -> Class -> Nutz.Models -> Product.cs -> // 002 - Product Management
- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 002 - Product Management
- Console -> Nutz.DataAccess -> Add-Migration AddProductToDb -> Update-Database

- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IProductRespository.cs -> // 002 - Product Management
- Edit -> Nutz.DataAccess -> Respository -> ProductRespository.cs -> // 002 - Product Management
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IUnitOfWork.cs -> // 002 - Product Management
- Edit -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 002 - Product Management

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> ProductController.cs -> // 002 - Product Management
- Add -> View -> ProductController.cs -> Index -> Razor View - Empty -> Index.cshtml -> @*002 - Product Management*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*002 - Product Management*@ 
- Add -> View -> ProductController.cs -> Upsert -> Razor View - Empty -> Upsert.cshtml -> @*002 - Product Management*@

- Add -> New Folder -> Nutz.Models -> View Models
- Add -> Class -> Nutz.Models -> ProductVM.cs -> // 002 - Product Management
