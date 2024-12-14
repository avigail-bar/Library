using Microsoft.AspNetCore.Mvc;
using Library.Entities;
using System.Reflection.PortableExecutable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Readers : ControllerBase
    {
        // GET: api/<Reader>
        [HttpGet]
        public IEnumerable<Entities.Reader> Get()
        {
            return DataContext.Readers;
        }

        // GET api/<Reader>/5
        [HttpGet("{id}")]
        public ActionResult<Entities.Reader> Get(int id)
        {
            Reader reader = DataContext.Readers.Find(e => e.Id == id);
            if(reader == null)
                return NotFound();
            else return reader;
        }

        // POST api/<Reader>
        [HttpPost]
        public void Post([FromBody] Reader reader)
        {
            DataContext.Readers.Add(reader);
           
        }

        // PUT api/<Reader>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Reader reader)
        {
            Reader r = DataContext.Readers.Find(e => e.Id == reader.Id);
            r.LastName = reader.LastName;
            r.FirstName = reader.FirstName;
            r.StartSubscription = reader.StartSubscription;
        }

        // DELETE api/<Reader>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataContext.Readers.Remove(DataContext.Readers.First(e => e.Id == id));
        }
    }
}
