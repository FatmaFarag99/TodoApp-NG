namespace TodoApp.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TodoApp.Todo;
    using Volo.Abp.Application.Services;

    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}