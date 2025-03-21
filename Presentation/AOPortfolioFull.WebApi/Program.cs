using AOPortfolioFull.Application.Extensions;
using AOPortfolioFull.Persistence.Extensions;
using AOPortfolioFull.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region PersistenceLayerExtensions
builder.Services.AddDbContextExtension(builder.Configuration);
builder.Services.AddGenericPatternExtension();
builder.Services.AddRepositoriesExtension();
builder.Services.AddUnitOfWorkExtension();
#endregion

#region ApplicationLayerExtensions
builder.Services.AddMediatorExtension();
builder.Services.AddMapsterExtension();
builder.Services.AddFluentValidationExtension();
builder.Services.AddServiceAndManagersExtensions();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapEndpoints(builder.Services);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
