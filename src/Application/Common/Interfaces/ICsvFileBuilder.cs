using NLP.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace NLP.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
