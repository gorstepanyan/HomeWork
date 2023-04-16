using Lesson42_OTUS_Middleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMiddleware<CustomExceptionPageMiddleware>();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseMiddleware<CustomHttpRedirectionMiddleware>();

//app.UseAuthentication();
app.UseMiddleware<CustomAuthenticationMiddleware>();

//app.UseAuthorization();
app.UseMiddleware<CustomAuthorizationMiddleware>();

app.MapControllers();

app.Run();
