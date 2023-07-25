using FinancialControl.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

//builder.Environment.EnvironmentName = builder.Environment.EnvironmentName;

ConfigureServices(builder.Services);

var app = builder.Build();

Configure(app);

app.Run();


void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerConfig();
}

void Configure(WebApplication app)
{
    app.UseSwaggerConfig();

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

}