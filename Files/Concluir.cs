namespace TaskManager
{
    class MarkComplete
    {
        public static void CompleteTask()
        {
            string[] linhas = File.ReadAllLines("Tarefas.txt");

            if (linhas.Length == 0)
            {
                Console.WriteLine("Sua Pasta está vazia");
                return;
            }

            Console.WriteLine("Digite o titulo da imagem que deseja completar");
            string tituloCompletar = Console.ReadLine();
            bool tarefaEncontrada = false;

            for (int i = 0; i < linhas.Length; i++)
            {

                string[] partes = linhas[i].Split(" - ");
                string titulo = partes[0].Trim();
                string concluida = partes[2].Trim();

                if (titulo.Equals(tituloCompletar, StringComparison.OrdinalIgnoreCase))
                {
                    partes[2] = "Sim";
                    linhas[i] = string.Join(" - ", partes);
                    tarefaEncontrada = true;
                    break;
                }
            }
            if (tarefaEncontrada)
            {
                File.WriteAllLines("Tarefas.txt", linhas);
                Console.WriteLine($"'{tituloCompletar}' marcada como concluida");
            }
            else
            {
                Console.WriteLine($"'{tituloCompletar}' não foi encontrada");
            }
            Console.WriteLine("Digite enter para continuar:");
            Console.ReadLine();
            Menu.ShowMenu();
        }
    }
}