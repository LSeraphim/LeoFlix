using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LeoFlix.Models;
using LeoFlix.Data;
using Microsoft.EntityFrameworkCore;


namespace LeoFlix.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Movie> movies = _context.Movies
        .Include(m => m.Genres)
        .ThenInclude(mv => mv.Genre)
        .ToList();
        return View(movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
