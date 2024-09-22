using TodoWebApi.Entities;

namespace TodoWebApi.Models
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; } = false;

        public TodoDTO() { }

        public TodoDTO(Todo todoItem)
        {
            Id = todoItem.Id;
            Title = todoItem.Title;
            IsComplete = todoItem.IsComplete;
        }
    }
}
