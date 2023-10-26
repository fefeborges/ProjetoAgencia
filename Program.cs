using Microsoft.EntityFrameworkCore;
using ProjetoAgencia.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*builder.Services.AddDbContext<Contexto> //Fernanda
    (options => options.UseSqlServer("Data Source=SB-1490653\\SQLSENAI;Initial Catalog = ProjetoAgencia;Integrated Security = True;TrustServerCertificate = True"));*/

/*builder.Services.AddDbContext<Contexto> //J�lia
    (options => options.UseSqlServer("Data Source=SB-1490628\\SQLSENAI;Initial Catalog = ProjetoAgencia;Integrated Security = True;TrustServerCertificate = True"));*/

/*builder.Services.AddDbContext<Contexto> //Caroline
    (options => options.UseSqlServer("Data Source=SB-1490624\\SQLSENAI;Initial Catalog = ProjetoAgencia;Integrated Security = True;TrustServerCertificate = True"));*/

/*builder.Services.AddDbContext<Contexto> //L�via
    (options => options.UseSqlServer("Data Source=SB-1490639\\SQLSENAI;Initial Catalog = ProjetoAgencia;Integrated Security = True;TrustServerCertificate = True"));*/

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
