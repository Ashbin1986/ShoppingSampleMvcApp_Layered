using ShoppingSampleMvcApp_Layered.Data;
using ShoppingSampleMvcApp_Layered.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ProductRepository>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddControllers(); // for Web API
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllers();


app.Run();
