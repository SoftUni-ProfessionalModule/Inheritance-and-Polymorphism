using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    DraftManager draftManager = new DraftManager();

    public void Run()
    {
        var inputLine = Console.ReadLine();

        while (inputLine != "Shutdown")
        {
            var commandArgs = inputLine.Split().ToList();
            var command = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(commandArgs)); 
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(commandArgs)); 
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(commandArgs));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(commandArgs));
                    break;
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine(draftManager.ShutDown());
    }
}