using Microsoft.EntityFrameworkCore;
using MyWebApplicationN.Configration;
using MyWebApplicationN.Context;
using MyWebApplicationN.Contracts;
using MyWebApplicationN.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(opt =>
                                               opt.UseInMemoryDatabase("WebApplicaton"));




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Auto Mapper
builder.Services.AddAutoMapper(typeof(MappingConfig));


builder.Services.AddScoped<IRoverRepository, RoversRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
