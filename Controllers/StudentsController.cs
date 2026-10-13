using domashnoBaza.Data;
using domashnoBaza.Models;
using Microsoft.AspNetCore.Mvc;

namespace domashnoBaza.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class StudentsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StudentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult GetAllStudents()
    {
        var students = _context.Students.ToList();
        return Ok(students);
    }

    [HttpGet]
    public ActionResult GetOneStudent([FromQuery] int id)
    {
        var student = _context.Students.Where(s => s.Id == id).First();
        return Ok(student);
    }
}