using App.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// app.UsePathBase("/dotnet"); 

if (app.Environment.IsDevelopment())
{
    // string swaggerBasePath = "api/app";
    
    // app.UseSwagger(c =>
    //         {
    //             c.RouteTemplate = swaggerBasePath + "/swagger/{documentName}/swagger.json";
    //         });

    // app.UseSwaggerUI(c =>
    // {
    //     c.SwaggerEndpoint($"/{swaggerBasePath}/swagger/v1/swagger.json", $"APP API - v1");
    //     c.RoutePrefix = $"{swaggerBasePath}/swagger";
    // });
    app.UseSwagger();
    app.UseSwaggerUI();


    app.UseDeveloperExceptionPage();
}

app.UseCors(builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });

app.UseAuthentication();

app.UseAuthorization();

// app.MapHub<ChatHub>("/Chat");

app.MapControllers();

app.Run();
