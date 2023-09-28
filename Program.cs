using JwtAspNet.Models;
using JwtAspNet.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<TokenService>();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", (TokenService service) =>
{
    var user = new User(
        1, 
        "Moises Alves", 
        "xyz@womi.com.br", 
        "http://womi.com.br/xyz", 
        "xyz", 
        new[] { "student", "premium" });

    return service.Create(user);
});

app.Run();
