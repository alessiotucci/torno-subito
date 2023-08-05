using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WorkIdentityNetCore.Data;
using WorkIdentityNetCore.Models.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// in a web core app we add a services add default identiy... 
builder.Services.AddDefaultIdentity<MyUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>(); // we will use a dbcontext too, all included at the start
builder.Services.AddRazorPages();

// we want to customize the password policy
builder.Services.Configure<IdentityOptions>(options =>
 {
     options.Password.RequiredLength = 10;
     options.Password.RequireDigit = false;
     options.Password.RequireLowercase = false;
     options.Password.RequireUppercase = false;
 }  );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
