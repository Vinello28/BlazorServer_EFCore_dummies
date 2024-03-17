using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class AziendaXdbContext : DbContext
{
    public AziendaXdbContext()
    {
    }

    public AziendaXdbContext(DbContextOptions<AziendaXdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Province> Provinces { get; set; }
}
