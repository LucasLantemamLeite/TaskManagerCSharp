namespace TaskManager
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string completed { get; set; } = "Não";
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}