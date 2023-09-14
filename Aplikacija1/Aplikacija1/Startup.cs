﻿using System.Text;
using Aplikacija1.Repository;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using static Aplikacija1.Service.UserServiceIMPL;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Konfiguracija za JWT autentikaciju
        var key = Encoding.ASCII.GetBytes("Vaša Tajna Ključ"); // Promenite ovo sa stvarnim tajnim ključem
        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false, // Ako želite da proverite izdavača (issuer)
                ValidateAudience = false // Ako želite da proverite auditorijum (audience)
            };
        });

        // Servis za User model
        services.AddScoped<UserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Servis za Post model
        services.AddScoped<PostService, PostService>();
        services.AddScoped<IPostRepository, PostRepository>();

        // Servis za Comment model
        services.AddScoped<CommentServiceIMPL, CommentServiceIMPL>();
        services.AddScoped<ICommentRepository, CommentRepository>();

        // Servis za Like model
        services.AddScoped<LikeService, LikeService>();
        services.AddScoped<ILikeRepository, LikeRepository>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}


