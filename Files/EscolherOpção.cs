namespace TaskManager
{
    class Options
    {
        public static void ChooseOption()
        {

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int userChoose) && userChoose > 0 && userChoose <= 6)
                {

                    switch (userChoose)
                    {
                        case 1:
                            AddTask.AddNewTask();
                            break;

                        case 2:
                            SeeTask.ShowTasks();
                            break;

                        case 3:
                            MarkComplete.CompleteTask();
                            break;
                        case 4:
                            DeleteTask.RemoveTask();
                            break;
                        case 5:
                            ClearConsole.ClearScreen();
                            break;

                        case 6:
                            Console.WriteLine("Saindo....");
                            System.Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Escolha uma opção váliada dentro do Menu");
                    Thread.Sleep(1000);
                    Menu.ShowMenu();
                }
            }
        }
    }
}