namespace TaskManager
{
    class ClearConsole
    {
        public static void ClearScreen()
        {
            Console.Clear();
            Menu.ShowMenu();
        }
    }
}