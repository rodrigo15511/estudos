using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using SistemaEscolarAPI.DB;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using FluentValidation.AspNetCore;
using Microsoft.IdentityModels.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PostgresConnection")));
=======
using SistemaEscolarAPI.Model;
using SistemaEscolarAPI.Db;
using SistemaEscolarAPI.DTO;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

var app = builder.Build();
>>>>>>> 22948f10f6d138c58abc0ec39f65248b8aa58081
