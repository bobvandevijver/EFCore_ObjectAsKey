using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Enitities;

namespace WebApplication1.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ValuesController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return _context.Books.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return _context.Books.Find(new BookId(id));
        }

        [HttpGet("create/{id}")]
        public ActionResult<Book> Post(int id)
        {
            var book = new Book(new BookId(id)) {value = $"Value{id}"};

            _context.Books.Add(book);
            _context.SaveChanges();

            return book;
        }
    }
}