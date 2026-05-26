using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly AppDbContext _context;

    public QuestionsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetQuestions()
    {
        var questions = await _context.Question.OrderBy(q => q.Id).ToListAsync();
        return Ok(questions);
    }

    [HttpPost]
    public async Task<IActionResult> CreateQuestion(Question question)
    {
        _context.Question.Add(question);
        await _context.SaveChangesAsync();
        return Ok(question);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteQuestion(int id)
    {
        var question = await _context.Question.FindAsync(id);
        if (question == null) return NotFound();

        _context.Question.Remove(question);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}