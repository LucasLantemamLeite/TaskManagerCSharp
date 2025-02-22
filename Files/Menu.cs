namespace TaskManager
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine($"Escolha uma opção:\n1 - Adicionar Tarefa\n2 - Listar Tarefas\n3 - Concluir Tarefa\n4 - Remover Tarefa\n5 - Limpar Tela\n6 - Sair");
            Options.ChooseOption();
        }
    }
}