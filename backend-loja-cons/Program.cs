using backend_loja_cons;

var builder = WebApplication.CreateBuilder(args);

var startup = new StartUp(builder.Configuration);

// Services
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();