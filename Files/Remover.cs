namespace TaskManager
{
    class DeleteTask
    {
        public static void RemoveTask()
        {
            string[] linhas = File.ReadAllLines("Tarefas.txt");

            if (linhas.Length == 0)
            {
                Console.WriteLine("Sua Pasta está vazia");
                return;
            }

            Console.WriteLine("Digite o titulo da imagem que deseja deletar");
            string tituloRemover = Console.ReadLine();
            bool tarefaEncontrada = false;

            List<string> novasLinhas = new List<string>();

            foreach (string linha in linhas)
            {

                string[] partes = linha.Split(" - ");

                string title = partes[0].Trim();

                if (title.Equals(tituloRemover, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Tarefa: '{tituloRemover}' removido da lista de tarefas");
                    tarefaEncontrada = true;
                }
                else
                {
                    novasLinhas.Add(linha);
                }

            }

            if (!tarefaEncontrada)
            {
                {
                    Console.WriteLine("Tarefa não encontrada.");
                }
            }
            else
            {
                File.WriteAllLines("Tarefas.txt", novasLinhas);
            }

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
            Menu.ShowMenu();


        }
    }
}