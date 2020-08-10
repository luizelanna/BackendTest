using BookService.Interface;
using BookService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBook _book;

        public BooksController(IBook book)
        {
            _book = book;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            return Ok(_book.GetAll());
        }

        [HttpGet("buscar/{type}/{ordem?}")]
        public ActionResult<IEnumerable<Books>> GetBooks(string type, string ordem)
        {
            return Ok(_book.GetLivro(type, ordem).ToList());
            //return enumerable.ToList();
        }

        // GET api/values/5
        [HttpGet("frete/{id}")]
        public ActionResult<double> GetFrete(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return NotFound();
            }
            return Ok(Convert.ToDouble(_book.GetFrete(id)));                      
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
