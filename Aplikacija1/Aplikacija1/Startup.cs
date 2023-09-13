using Aplikacija1.Repository;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using static Aplikacija1.Service.PostServiceIMPL;
using static Aplikacija1.Service.UserServiceIMPL;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {


        // Servis za User model
        services.AddScoped<UserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Servis za Post model
        services.AddScoped<PostService, PostService>();
        services.AddScoped<IPostRepository, PostRepository>();

        // Servis za Comment model
        services.AddScoped<CommentService, CommentService>();
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


