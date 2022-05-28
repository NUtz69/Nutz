using Microsoft.EntityFrameworkCore;
using Nutz.DataAccess;
using Nutz.DataAccess.Respository;
using Nutz.DataAccess.Respository.IRespository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Nutz.Utility;

var builder = WebApplication.CreateBuilder(args);

// 004 - Identity Management
builder.Services.AddIdentity<IdentityUser, IdentityRole>(/*options => options.SignIn.RequireConfirmedAccount = true*/).AddDefaultTokenProviders()
    .AddEntityFrameworkStores<ApplicationDbContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();

// 000 - Create Project
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// 001 - Repository Pattern
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// 004 - Identity Management
builder.Services.AddSingleton<IEmailSender, EmailSender>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// 005 - Shopping Cart
builder.Services.ConfigureApplicationCookie(options => 
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

// 004 - Identity Management
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    // 001 - Repository Pattern
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();
