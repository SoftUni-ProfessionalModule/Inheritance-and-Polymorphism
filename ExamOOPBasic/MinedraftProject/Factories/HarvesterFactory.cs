using System.Collections.Generic;

public class HarvesterFactory
{
    public Harvester RegHarvester(List<string> parameters)
    {
        Harvester harvester = null;
        var harvesterType = parameters[0];
        parameters.RemoveAt(0);

        switch (harvesterType)
        {
            case "Sonic":
                harvester = new SonicHarvester(parameters[0], double.Parse(parameters[1]), double.Parse(parameters[2]), int.Parse(parameters[3]));
                break;
            case "Hammer":
                harvester = new HammerHarvester(parameters[0], double.Parse(parameters[1]), double.Parse(parameters[2]));
                break;
        }

        return harvester;
    }
}