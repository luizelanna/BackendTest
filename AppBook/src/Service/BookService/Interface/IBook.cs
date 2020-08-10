using BookService.Models;
using System.Collections.Generic;

namespace BookService.Interface
{
    public interface IBook : IRepositorio<Books>
    {
        IEnumerable<Books> GetLivro(string entity,string ordem);
        object GetFrete(int id);
    }
}
