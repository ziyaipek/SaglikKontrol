using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;
using Web.Middlewares;
using Web.Utilities;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var cultureInfo = new CultureInfo("tr-Tr");
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", cBuilder =>
{
    cBuilder.AllowAnyHeader()
    .WithOrigins("http://localhost:4200") // Angular uygulamasının adresi
    .AllowAnyMethod()
    .SetIsOriginAllowed(_ => true)
    .AllowCredentials();
}));
var postgresConnectionString =
builder.Configuration.GetConnectionString("PsqlConnection");
builder.Services.AddDbContext<PostgresContext>(dbContextOptionsBuilder =>
dbContextOptionsBuilder.UseNpgsql(postgresConnectionString,
npgsqlDbContextOptionsBuilder =>
npgsqlDbContextOptionsBuilder.MigrationsAssembly("Infrastructure")));
builder.Services.AddSignalR();
// Add services to the container.
builder.Services.AddMySingleton();
builder.Services.AddMyScoped();
builder.Services.AddMyTransient();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}
);
// Learn more about configuring Swagger/OpenAPI at
https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Akademi Portal",
        Description = ".NET 7 / ASP.NET Core Web API",
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "'Bearer' [boşluk] 'tokeniniz' şeklinde aşağıdaki alanı doldurunuz..Örnek:selamlar"
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
{
new OpenApiSecurityScheme {
Reference = new OpenApiReference {
Type = ReferenceType.SecurityScheme,
Id = "Bearer",
}
},
new string[] {}
}
});
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(jwtBearerOptions =>
{
    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["TokenOptions:Issuer"],
        ValidAudience = builder.Configuration["TokenOptions:Audience"],
        IssuerSigningKey = new
    SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenOptions:SecurityKey"])),
    ClockSkew = TimeSpan.Zero
    };
});
var app = builder.Build();
app.Use(async (context, next) =>
{
    var accessToken = context.Request.Query["access_token"];
    if (!string.IsNullOrEmpty(accessToken))
    {
        context.Request.Headers["Authorization"] = "Bearer " + accessToken;
    }
    await next.Invoke().ConfigureAwait(false);
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();