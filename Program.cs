using HomeManager.Data;
using HomeManager.Repositories;
using HomeManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register Mongo settings
builder.Services.Configure<MongoDbSettings>(
builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<MongoContext>();

// DI for Repos and Services
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMenuRepository, MenuRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMenuService, MenuService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
