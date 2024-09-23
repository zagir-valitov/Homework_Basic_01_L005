namespace Homework_Basic_01;

internal class Program
{
    static void HelpCommand()
    {
        Console.WriteLine("The following commands are available to you:\n" +
            "/start - Start/restart the bot\n" +
            "/help  - Command reference\n" +
            "/info  - Information about the program version and the date of its creation\n" +
            "/echo  - After entering the name, the /echo command becomes available.\n" +
            "         When you enter this command with an argument (for example, /echo Hello),\n" +
            "         the program returns the entered text (in this example, \"Hello\")\n" +
            "/exit  - End the program\n");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!\n");
        HelpCommand();

        string? name = "";

        while (true)
        {
            if (name == "")
            {
                Console.Write("Please enter the command: ");
            }
            else
            {
                Console.Write(name + ", please enter the command: ");
            }

            var command = Console.ReadLine();
            if (command == "")
            {
                continue;
            }
            
            if (command == "/exit")
            {
                Console.Write("End the program\n");
                break;
            }

            switch (command)
            {
                case "/help":
                    HelpCommand();
                    continue;
                case "/info":
                    Console.WriteLine("Program version: 1.1\n" +
                        "Date of creation: 2024.06.22\n");
                    continue;
                case "/start":
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine();
                    continue;
            }           
            
            string[] words = command.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
            if (words[0] == "/echo" && name != "" && words.Length == 2)
            {
                Console.WriteLine(words[1]);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ivalid command input. To access help, enter the command \"/help\" !!!\n");
            }             
        }
    }
}
