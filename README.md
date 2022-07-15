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

- Edit -> Nutz.Web -> Areas -> Admin -> Product -> Index.cshtml -> // 002 - Product Management
- Add -> Nutz.Web -> wwwroot -> js -> New Item -> JavaScript -> product.js -> // 002 - Product Management
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IRespository.cs -> // 002 - Product Management
- Edit -> Nutz.DataAccess -> Respository -> Respository.cs -> // 002 - Product Management
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> ProductController.cs -> // 002 - Product Management
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Product -> Upsert.cs -> // 002 - Product Management
- Edit -> Nutz.Web -> Views -> Shared -> _Notification.cshtml -> @*002 - Product Management*@

@ Home Page

> 003 - Home Page

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> HomeController.cs -> // 003 - Home Page
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Home -> Index.cshtml -> @*003 - Home Page*@
- Add -> Class -> Nutz.Models -> ShoppingCart.cs -> // 003 - Home Page
- Add -> View -> HomeController.cs -> Details -> Razor View -> Details.cshtml -> @*003 - Home Page*@

@ Identity Management

> 004 - Identity Management

- Nuget -> Microsoft.AspNetCore.Identity.EntityFrameworkCore -> Install
- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 004 - Identity Management
- Add -> Nutz.Web -> New Scaffolded Item -> Identity -> Override all files + ApplicationDbContext 
- Edit -> Nutz.Web -> Program.cs -> // 004 - Identity Management

- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*004 - Identity Management*@
- Edit -> Nutz.Web -> Views -> Shared -> _LoginPartial.cshtml -> @*004 - Identity Management*@
- Edit -> Nutz.Web -> Program.cs -> // 004 - Identity Management
- Console -> Nutz.DataAccess -> Add-Migration AddIdentityToDb -> Update-Database

- Edit -> Class -> Nutz.Models -> ApplicationUser.cs -> // 004 - Identity Management
- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 004 - Identity Management
- Console -> Nutz.DataAccess -> Add-Migration ExtendIdentityUser -> Update-Database

- Edit -> Class -> Nutz.Models -> Company.cs -> // 004 - Identity Management
- Edit -> Class -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 004 - Identity Management
- Console -> Nutz.DataAccess -> Add-Migration AddCompanyToDb -> Update-Database
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IComparyRespository.cs -> // 004 - Identity Management
- Edit -> Nutz.DataAccess -> Respository -> CompanyRespository.cs -> // 004 - Identity Management
- Edit -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> CompanyController.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> wwwroot -> js -> company.js -> // 004 - Identity Management
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Company -> Index.cshtml -> @*004 - Identity Management*@
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Company -> Upsert.cshtml -> @*004 - Identity Management*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*004 - Identity Management*@

- Edit -> Nutz.Web -> Program.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml.cs -> // 004 - Identity Management
- Edit -> Nutz.Utility -> SD.cs -> // 004 - Identity Management
- Edit -> Nutz.Utility -> EmailSender.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> Program.cs -> // 004 - Identity Management

- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml -> @*004 - Identity Management*@
 
- Edit -> Class -> Nutz.Models -> ApplicationUser.cs -> // 004 - Identity Management
- Console -> Nutz.DataAccess -> Add-Migration AddCompanyIdToUser -> Update-Database
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml.cs -> // 004 - Identity Management
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml -> @*004 - Identity Management*@

- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Register.cshtml.cs -> // 004 - Identity Management

@ Shopping Cart

> 005 - Shopping Cart

- Edit -> Nutz.Models -> ShoppingCart.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 005 - Shopping Cart
- Console -> Nutz.DataAccess -> Add-Migration AddShoppingCartToDb -> Update-Database

- Edit -> Nutz.DataAccess -> Respository -> ShoppingCartRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> ApplicationUserRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IShoppingCartRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IApplicationUserRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IUnitOfWork.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 005 - Shopping Cart

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> HomeController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Home -> Details.cshtml -> @*005 - Shopping Cart*@
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Home -> Index.cshtml -> @*005 - Shopping Cart*@

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> HomeController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IShoppingCartRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> ShoppingCartRespository.cs -> // 005 - Shopping Cart

- Edit -> Nutz.Web -> Program.cs -> // 005 - Shopping Cart

- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*005 - Shopping Cart*@
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Index.cshtml -> @*005 - Shopping Cart*@

- Edit-> Nutz.Models -> ViewModels -> ShoppingCartVM.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> Respository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IRespository.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Models -> ShoppingCart.cs -> // 005 - Shopping Cart

- Edit-> Nutz.Models -> ViewModels -> ShoppingCartVM.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 005 - Shopping Cart
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Index.cshtml -> @*005 - Shopping Cart*@

- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Summary.cshtml -> @*005 - Shopping Cart*@

@ Order Creation

> 006 - Order

- Edit-> Nutz.Models -> OrderHeader.cs -> // 006 - Order
- Edit-> Nutz.Models -> OrderDetail.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Data -> ApplicationDbContext.cs -> // 006 - Order
- Console -> Nutz.DataAccess -> Add-Migration AddOrderHeaderAndOrderDetailToDb -> Update-Database

- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IOrderHeaderRespository.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IOrderDetailRespository.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> OrderHeaderRespository.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> OrderDetailRespository.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IUnitOfWork.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> UnitOfWork.cs -> // 006 - Order

- Edit-> Nutz.Models -> ViewModels -> ShoppingCartVM.cs -> // 006 - Order
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 006 - Order
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Index.cshtml -> @*006 - Order*@

- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Summary.cshtml -> @*006 - Order*@

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 006 - Order
- Edit -> Nutz.Utility -> SD.cs -> // 006 - Order

=> Stripe

- Edit -> Nutz.Web -> appsettings.json -> // 006 - Order
- Edit -> Nutz.Utility -> StripeSettings.cs -> // 006 - Order
- Edit -> Nutz.Web -> Program.cs -> // 006 - Order
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> Summary.cshtml -> @*006 - Order*@
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> OrderHeaderRespository.cs -> // 006 - Order
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IOrderHeaderRespository.cs -> // 006 - Order
- Edit -> Nutz.Web -> Areas -> Customer -> Views -> Cart -> OrderConfirmation.cshtml -> @*006 - Order*@

@ Order Management

> 007 - Order Management

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 007 - Order Management

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> OrderController.cs -> // 007 - Order Management
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Order -> Index.cshtml -> @*007 - Order Management*@
- Edit-> Nutz.Models -> ViewModels -> OrderVM.cs -> // 007 - Order Management

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> OrderController.cs -> // 007 - Order Management
- Edit -> Nutz.Web -> wwwroot -> js -> order.js -> // 007 - Order Management
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Order -> Index.cshtml -> @*007 - Order Management*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*007 - Order Management*@

- Edit -> Nutz.Web -> wwwroot -> js -> order.js -> // 007 - Order Management
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> OrderController.cs -> // 007 - Order Management

- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Order -> Details.cshtml -> @*007 - Order Management*@
- Edit -> Nutz.DataAccess -> Respository -> OrderHeaderRespository.cs -> // 007 - Order Management
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> OrderController.cs -> // 007 - Order Management
- Edit -> Nutz.DataAccess -> Respository -> IRespository -> IRespository.cs -> // 007 - Order Management
- Edit -> Nutz.DataAccess -> Respository -> Respository.cs -> // 007 - Order Management

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> OrderController.cs -> // 007 - Order Management
- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Order -> Details.cshtml -> @*007 - Order Management*@

- Edit -> Nutz.Web -> Areas -> Admin -> Views -> Order -> PaymentConfirmation.cshtml -> @*007 - Order Management*@

@ MVC Advance Concepts

> 008 - Advance Concepts

- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> CategoryController.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> CompanyController.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> CoverTypeController.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Areas -> Admin -> Controllers -> ProductController.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*008 - Advance Concepts*@

- Nuget -> MailKit -> Install
- Nuget -> MimeKit -> Install
- Edit -> Nutz.Utility -> EmailSender.cs -> // 008 - Advance Concepts

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 008 - Advance Concepts

- Edit -> Nutz.Web -> appsettings.json -> // 008 - Advance Concepts
- Edit -> Nutz.Utility -> EmailSender.cs -> // 008 - Advance Concepts
- Nuget -> SendGrid -> Install

- Edit -> Nutz.Web -> Program.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Utility -> SD.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Controllers -> HomeController.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*008 - Advance Concepts*@
- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 008 - Advance Concepts

- Edit -> Nutz.Web -> ViewComponents -> ShoppingCartViewComponent.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Views -> Shared -> Components -> ShoppingCart -> Default.cshtml -> @*008 - Advance Concepts*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*008 - Advance Concepts*@

- Nuget -> Microsoft.AspNetCore.Authentication.Facebook -> Install
- https://developers.facebook.com/
- Edit -> Nutz.Web -> Program.cs -> // 008 - Advance Concepts
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Account -> ExternalLogin.cshtml -> @*008 - Advance Concepts*@
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Account -> ExternalLogin.cshtml.cs -> // 008 - Advance Concepts

- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Account -> Register.cshtml -> @*008 - Advance Concepts*@
- Edit -> Nutz.Web -> Views -> Shared -> _Layout.cshtml -> @*008 - Advance Concepts*@
- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Account -> Register.cshtml.cs -> // 008 - Advance Concepts

- Edit -> Nutz.Web -> Areas -> Customer -> Controllers -> CartController.cs -> // 008 - Advance Concepts

@ Seed Database and Azure Deployment

> 009 - Azure

- Edit -> Nutz.Web -> Areas -> Identity -> Pages -> Account -> Register.cshtml.cs -> // 009 - Azure
- Edit -> Nutz.Web -> appsettings.json -> // 009 - Azure
- Console -> Nutz.DataAccess -> Update-Database
- Edit -> Nutz.DataAccess -> DbInitializer -> Interface -> IDbInitializer.cs -> // 009 - Azure
- Edit -> Nutz.DataAccess -> DbInitializer -> Class -> DbInitializer.cs -> // 009 - Azure
