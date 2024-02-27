using ApiDependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddKeyedSingleton<IMyClass, MyClass>("Singleton");
builder.Services.AddKeyedScoped<IMyClass, MyClass>("Scoped");
builder.Services.AddKeyedTransient<IMyClass, MyClass>("Transient");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
