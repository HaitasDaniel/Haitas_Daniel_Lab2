using Microsoft.EntityFrameworkCore;

public class Haitas_Daniel_Lab2Context(DbContextOptions<Haitas_Daniel_Lab2Context> options) : DbContext(options)
{
    public DbSet<Haitas_Daniel_Lab2.Models.Book> Book { get; set; } = default!;
}
