using FSI.ActionScore.Application.DependencyInjection;
using FSI.ActionScore.Application.Mapper;
using FSI.ActionScore.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Application e Infrastructure (DDD)
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

// Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
