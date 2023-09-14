using Aplikacija1.Model;
using Microsoft.EntityFrameworkCore;

public class IdentityDbContext<T>
{
    private DbContextOptions<AppDbContext> options;

    public IdentityDbContext(DbContextOptions<AppDbContext> options)
    {
        this.options = options;
    }
}