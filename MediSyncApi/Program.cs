
using MediSyncApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<MediSyncContext>(options =>
    options.UseSqlite("Data Source=medisync.db"));

// Allow the local frontend to call the backend.
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
var frontendPath = @"C:\Users\Desktop\Downloads\Frontend";

app.UseDefaultFiles(new DefaultFilesOptions
{
    FileProvider = new PhysicalFileProvider(frontendPath)
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(frontendPath)
}); 
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Enable CORS before mapping controllers.
app.UseCors("Frontend");

app.UseAuthorization();
app.MapControllers();

app.Run();
