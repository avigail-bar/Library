using Microsoft.AspNetCore.Mvc;
using Library.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Questions : ControllerBase
    {
        // GET: api/<Question>
        [HttpGet]
        public IEnumerable<Entities.Question> Get()
        {
            return DataContext.Questions;
        }

        // GET api/<Question>/5
        [HttpGet("{id}")]
        public Question Get(int id)
        {
            return DataContext.Questions.FirstOrDefault(e=>e.id==id);

        }

        // POST api/<Question>
        [HttpPost]
        public void Post([FromBody] Question question)
        {
            DataContext.Questions.Add(question);

        }

        // PUT api/<Question>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DateTime S,DateTime e,int count)
        {
            Question question = DataContext.Questions.FirstOrDefault(e=>e.id==id);
            question.start = S;
            question.end = e;
            question.countDays = count;
            return;
        }

        // DELETE api/<Question>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Question question=DataContext.Questions.FirstOrDefault(e=>e.id==id);
            DataContext.Questions.Remove(question);
        }
    }
}
