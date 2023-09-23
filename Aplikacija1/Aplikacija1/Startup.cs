using System.Text;
using Aplikacija1.Repositories;
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

        //services.AddDbContext<AppDbContext>();
        // Servis za User model
        services.AddScoped<UserServiceIMPL, UserServiceIMPL>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Servis za Post model
        services.AddScoped<PostServiceIMPL, PostServiceIMPL>();
        services.AddScoped<IPostRepository, PostRepository>();

        // Servis za Comment model
        services.AddScoped<CommentServiceIMPL, CommentServiceIMPL>();
        services.AddScoped<ICommentRepository, CommentRepository>();

        // Servis za Like model
        services.AddScoped<LikeServiceIMPL, LikeServiceIMPL>();
        services.AddScoped<ILikeRepository, LikeRepository>();

        // Servis za Follow model
        services.AddScoped<IFollowService, FollowServiceIMPL>();
        services.AddScoped<IFollowRepository, FollowRepository>();

        // Servis za Notification model
        services.AddScoped<INotificationService, NotificationServiceIMPL>();
        services.AddScoped<INotificationRepository, NotificationRepository>();

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


