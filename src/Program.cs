using InvestCalc.Services;

var builder = WebApplication.CreateBuilder(args);

// I added services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI: registered only what we use in HW2
builder.Services.AddScoped<LocalCalcService>();

var app = builder.Build();

// Configured the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

//Roni