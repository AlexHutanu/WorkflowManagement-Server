
using Microsoft.Data.SqlClient;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IService<Board>, BoardService>();
builder.Services.AddScoped<IService<BugTicket>, BugTicketService>();
builder.Services.AddScoped<IService<Activity>, ActivitiesService>();
builder.Services.AddScoped<IService<User>, UserService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
