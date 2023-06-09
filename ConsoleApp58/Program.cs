namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandCloseProgram = "exit";
            string userInput;
            bool isUserExit = false;

            while (isUserExit == false)
            {
                Console.WriteLine("Введите команду - " + "\"" + commandCloseProgram + "\"" + " для закрытия программы.");
                userInput = Console.ReadLine();

                if (userInput == commandCloseProgram)
                {
                    isUserExit = true;
                }
            }
        }
    }
}