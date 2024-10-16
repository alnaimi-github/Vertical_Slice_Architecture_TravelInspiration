using TravelInspiration.API;
using TravelInspiration.API.Features.SearchDestinations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddHttpClient();
   
builder.Services.RegisterApplicationServices();
builder.Services.RegisterPersistenceServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler();
}
app.UseStatusCodePages();

SearchDestinations.AddEndpoint(app);

app.Run();