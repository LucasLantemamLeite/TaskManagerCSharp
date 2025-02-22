namespace TaskManager
{
    class SeeTask
    {
        public static void ShowTasks()
        {
            Console.WriteLine("=========================");
            string[] linhas = File.ReadAllLines("Tarefas.txt");

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(" - ");

                string titulo = partes[0].Trim();
                string descricao = partes[1].Trim();
                string concluida = partes[2].Trim();

                Console.WriteLine($"Titulo: {titulo}\nDescrição: {descricao}\nConcluída: {concluida}");
                Console.WriteLine("=========================");
            }
            Console.WriteLine("Presione 'enter' para continuar");
            Console.ReadLine();
            Menu.ShowMenu();
        }
    }
}