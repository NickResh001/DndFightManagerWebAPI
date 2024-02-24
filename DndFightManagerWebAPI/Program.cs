using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System.Text.Json.Serialization;
using DAL.Entities;
using DAL.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
    builder =>
    {
        builder.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddJsonOptions(x =>
x.JsonSerializerOptions.ReferenceHandler =
ReferenceHandler.IgnoreCycles);

// Add services to the container.
builder.Services.AddIdentity<User, IdentityRole>()
.AddEntityFrameworkStores<DndFightManagerDBContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "DndFightManagerCookie";
    options.LoginPath = "/";
    options.AccessDeniedPath = "/";
    options.LogoutPath = "/";
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };
    // sss
    options.Events.OnRedirectToAccessDenied = context =>
    {
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };
});

builder.Services.AddDbContext<DndFightManagerDBContext>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var dndFightManagerDBContext =
    scope.ServiceProvider.GetRequiredService<DndFightManagerDBContext>();
    //await DbInitializer.CreateUserRoles(scope.ServiceProvider);
    //await DbInitializer.Initialize(dndFightManagerDBContext);

}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
//app.UseAuthorization();
//app.MapControllers();
//app.Run();

