using Microsoft.AspNetCore.Mvc;
using Showcaseopdr.Data;

namespace Showcaseopdr.Controllers;

public class ActivityController : Controller
{
    private readonly TaskDbContext _context;
    // GET activities 
    
    public IActionResult ViewActivity()
    {
        return View();
    }

    public IActionResult GetActivities()
    {
        // Haal alle activiteiten op uit de database
        List<Models.Task> tasks;

        using (var TaskContext = new TaskDbContext())
        {
            tasks = TaskContext.Tasks.ToList();
        }
        return Ok(tasks);
    }   

    // Add activity 
    // Haal de form informatie uit de view op en sla deze op in de database
    
    public IActionResult AddActivity(Models.Task task)
    {
        // if(!this.ModelState.IsValid)
        // {
        //     return View();
        // }
        using (var context = new TaskDbContext())
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }
        Console.WriteLine("Toegevoegd");
        return Ok();
    }
    



    // Edit activity
    // Haal de form informatie uit de view op en sla deze op in de database
    // replace de oude acitivity met de nieuwe activity
    
    
    // // GET
    // public IActionResult Index()
    // {
    //     return View();
    // }
}