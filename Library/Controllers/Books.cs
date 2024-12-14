using Library.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books : ControllerBase
    {

        // GET: api/<Book>
        [HttpGet]
        public IEnumerable<Entities.Book> Get() 
        {
            return DataContext.Books;
        }

        // GET api/<Book>/5
        [HttpGet("{id}")]
        public ActionResult<Entities.Book> Get(int id)
        {
            Book book = DataContext.Books.Find(b => b.Id == id);
            if(book==null)
                return NotFound();

           else return book;

        }

        // POST api/<Book>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            DataContext.Books.Add(new Book { Id = DataContext.Books.Max(e => e.Id) + 1, Name = book.Name, Author = book.Author });
        }

        // PUT api/<Book>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            if(DataContext.Books.Find(e=>e.Id == id) == null)
                return;
            Book book1= DataContext.Books.Find(e=>e.Id == id);
            book1.Name=book.Name;
            book1.Author=book.Author;
            return;
        }

        // DELETE api/<Book>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book book = DataContext.Books.Find(e => e.Id == id);
            DataContext.Books.Remove(book);
        }
    }
}
