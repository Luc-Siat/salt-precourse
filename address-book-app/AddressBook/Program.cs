using AddressBook.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
          builder => builder
            .AllowAnyMethod()
            .AllowCredentials()
            .SetIsOriginAllowed((host) => true)
            .AllowAnyHeader());
});
// app.options('/*', (_, res) => {
//     res.sendStatus(200);
// });

// Response.AppendHeader("Access-Control-Allow-Origin", "*");

// Add services to the container.
var db = new Db();
builder.Services.AddSingleton<Db>(db);



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

// services.AddHttpsRedirection(opt => opt.HttpsPort = 443);
app.UseHttpsRedirection();

app.UseCors();




app.UseAuthorization();

app.MapControllers();

app.Run();
