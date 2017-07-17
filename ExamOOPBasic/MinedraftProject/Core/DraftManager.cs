using System;
using System.Collections.Generic;

public class DraftManager
{
    HarvesterFactory harvest = new HarvesterFactory();
    ProvidersFactory provider = new ProvidersFactory();
    Mine mine = new Mine();

    public DraftManager()
    {
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester harvester = null;

            harvester = harvest.RegHarvester(arguments);
            mine.RegHarvester(harvester);
            return harvester.ToString();
 
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }    
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider newProvider = null;

            newProvider = provider.RegProvider(arguments);
            mine.RegProvider(newProvider);
            return newProvider.ToString();
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }
    public string Day()
    {
        return mine.GetDayCommand();
    }
    public string Mode(List<string> arguments)
    {
        return mine.ChengeMode(arguments[0]);
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        return mine.GetCheckCommand(arguments[0]);
    }
    public string ShutDown()
    {
        return mine.GetShutDown();
    }
}