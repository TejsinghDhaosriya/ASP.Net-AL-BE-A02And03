using CalculatorWebApplication.Filter;
using CalculatorWebApplication.Service.Interface;
using MathService = CalculatorWebApplication.Service.Impl.MathService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Also removing null field from response
// builder.Services.AddControllers().AddJsonOptions(options => {
//     options.JsonSerializerOptions.IgnoreNullValues = true;
// });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//per request object
builder.Services.AddScoped<IMathService,MathService>();
builder.Services.AddScoped<ValidateCalculateRequestFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


public partial class Program { }