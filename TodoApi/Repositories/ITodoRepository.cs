using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);
        bool Update(Todo todo);
        bool Delete(int id);
        Todo Create(Todo todo);
    }
}
