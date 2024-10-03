using WhatDYouDoAPI.Data;
using WhatDYouDoAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/actvity", 
    () => Results.Ok(ActivityDirectory.Activities))
    .WithName("GetActivities").Produces<IEnumerable<Activity>>(201).Produces(400);

app.UseHttpsRedirection();

app.Run();

