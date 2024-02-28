var builder = WebApplication.CreateBuilder();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Hit the /products endpoint to retrieve a list of products!");
});

app.MapGet("/products", () =>
{
    return Product.GetAll();
})
.WithName("GetProducts");

app.Run();

record Product(int Id, string Title, string Category)
{
     public static List<Product> GetAll(){
         var products = new List<Product>(){
            new Product(1, "Evolution Container Apps", "Разработчики"),
            new Product(2, "Evolution Serverless Functions", "Разработчики"),
            new Product(3, "Evolution Artifact Registry", "Разработчики"),
            new Product(4, "Evolution API Gateway", "Разработчики"),
         };

        return products; 
     }
}