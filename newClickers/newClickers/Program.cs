using System;

namespace newClickers
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandSet = new CommandSet();
            while (true)
            {
                var command = Console.ReadKey().KeyChar;
                commandSet.RunCommand(command);
            }
        }
    }

}
