using Microsoft.EntityFrameworkCore;
using Nutz.DataAccess;
using Nutz.DataAccess.Repository;
using Nutz.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Nutz.Utility;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// 004 - Identity Management
builder.Services.AddIdentity<IdentityUser, IdentityRole>(/*options => options.SignIn.RequireConfirmedAccount = true*/).AddDefaultTokenProviders()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// 000 - Create Project
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// 006 - Order
builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));

// 001 - Repository Pattern
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
// 004 - Identity Management
builder.Services.AddSingleton<IEmailSender, EmailSender>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// 008 - Facebook
builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.AppId = "712293706844005";
    options.AppSecret = "17821f51b7ab0df4cac5c1a185b1345c";
});

// 005 - Shopping Cart
builder.Services.ConfigureApplicationCookie(options => 
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

// 008 - Advance Concepts
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
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

// 006 - Order
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();

app.UseAuthentication();
app.UseAuthorization();

// 008 - Advance Concepts
app.UseSession();

// 004 - Identity Management
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    // 001 - Repository Pattern
    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

app.Run();
