namespace TodoWebApi.Models
{
    public class UpdateTodoDTO
    {
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; } = false;
    }
}
