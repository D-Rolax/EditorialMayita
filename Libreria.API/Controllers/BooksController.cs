using Libreria.API.Date;
using Libreria.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Libreria.API.Controllers
{
    [ApiController]
    [Route("/api/books")]
    public class BooksController:ControllerBase
    {
        private readonly DataContext _context;

        public BooksController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult>PostAsync(Book book)
        {
            _context.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var book=await _context.Books.ToListAsync();
            return Ok(book);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(
                x=>x.Id==id);
            if (book==null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPut]
        public async Task<ActionResult> PutAsync(Book book)
        {
            _context.Update(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(
                x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
