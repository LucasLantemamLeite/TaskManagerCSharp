namespace TaskManager
{
    class AddTask
    {
        public static void AddNewTask()
        {
            Console.WriteLine("Digite o titulo da tarefa: ");
            string title = Console.ReadLine();

            Console.WriteLine("Digite a descrição da tarefa");
            string description = Console.ReadLine();

            var newTask = new Task(title, description);

            string[] file = File.ReadAllLines("Tarefas.txt");

            string content = $"{newTask.Title} - {newTask.Description} - Não";

            if (file.Length == 0)
            {
                File.AppendAllText("Tarefas.txt", content);
            }
            else
            {
                File.AppendAllText("Tarefas.txt", "\n" + content);
            }


            Console.WriteLine("Tarefa Adicionada");
            Thread.Sleep(1000);
            Menu.ShowMenu();
        }
    }
}