using NSE.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddIdentityConfiguration();
builder.Services.AddMvcConfiguration();
builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMvcConfiguration(builder.Environment);

app.Run();
