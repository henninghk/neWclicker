using System;
using System.Collections.Generic;
using System.Text;

namespace newClickers
{
    class CommandSet
    {
        private ICommand[] _commands = new ICommand[]
        {
            new Click(),
            new Upgrade(),
            new UpgradeUpgrade(),
            new Exit(),
        };

        public void RunCommand(char command)
        {
            command = char.ToLower(command);
            if (command == ' ') _commands[0].Run();
            else if (command == 'u') _commands[1].Run();
            else if (command == 's') _commands[2].Run();
            else if (command == 'x') _commands[3].Run();
            Show();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - U = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine("Trykk tast for ønsket kommando.\n");
            Console.WriteLine($"Du har {ClickerGame.points} poeng.");
            Console.WriteLine($"Du har {ClickerGame.UpgradeCounter} upgrades.");
            Console.WriteLine($"Du har {ClickerGame.UpgradeUpgradeCounter} upgrade upgrades.");
        }
    }
}
