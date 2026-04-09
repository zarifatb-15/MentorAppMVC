using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class MentorAppDbContext:DbContext
{
public DbSet<Slider>Sliders{get;set;}

public MentorAppDbContext(DbContextOptions<MentorAppDbContext> options) : base(options)
{
    
}
}