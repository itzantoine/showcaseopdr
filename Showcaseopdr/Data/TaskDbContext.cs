using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Showcaseopdr.Data;

public class TaskDbContext:DbContext
{
    public DbSet<Models.Task> Tasks { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        
        optionsBuilder.UseSqlite("Data Source=tijdschrijf.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Models.Task>(task =>
        {
            task.HasKey(t => t.TaskNumberId);
            task.Property(t => t.Date).IsRequired();
            task.Property(t => t.TaskName).IsRequired();
            task.Property(t => t.StartTime).IsRequired();
            task.Property(t => t.EndTime).IsRequired();
            task.Property(t => t.Present).IsRequired();
            
            modelBuilder.Entity<Models.Task>().HasData(
                new Models.Task()
                {
                    TaskNumberId = 1,
                    Date = new DateTime(2023, 03, 19),
                    TaskName = "Test",
                    StartTime = new DateTime(2023, 03, 19, 8, 0, 0),
                    EndTime = new DateTime(2023, 03, 19, 16, 0, 0),
                    Present = false,
                }
            ); 
        });
    }
    
    
}