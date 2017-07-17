using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsProject
{
    public class Startup
    {
        public static void Main()
        {
            var commandInterpreter = new CommandInterpreter();

            var inputLine = Console.ReadLine();

            while (inputLine != "Paw Paw Pawah")
            {
                commandInterpreter.GetCommand(inputLine);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(commandInterpreter.GetStatistic());
        }
    }
}