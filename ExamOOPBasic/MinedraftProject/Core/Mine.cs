using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Mine
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string modeType;
    private double totalEnergyStored;
    private double totalOrStored;

    public Mine()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.modeType = string.Empty;
    }

    public void RegHarvester(Harvester harvester)
    {
        this.harvesters.Add(harvester);
    }

    public void RegProvider(Provider provider)
    {
        this.providers.Add(provider);
    }

    public string GetCheckCommand(string id)
    {
        if (harvesters.Any(h => h.Id == id))
        {
            Harvester currentHarvester = null;

            currentHarvester = harvesters.Single(h => h.Id == id);

            return currentHarvester.PrintCheck();
        }
        else if (providers.Any(h => h.Id == id))
        {
            Provider currentProvider = null;

            currentProvider = providers.Single(h => h.Id == id);

            return currentProvider.PrintCheck();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }

    public string ChengeMode(string type)
    {
        this.modeType = type;

        return $"Successfully changed working mode to {type} Mode";
    }

    public string GetDayCommand()
    {
        var energyRequirement = this.harvesters.Sum(harvester => harvester.EnergyRequirment);
        var energyProvided = this.providers.Sum(provider => provider.EnergyOutput);

        if (this.modeType == "Half")
        {
            energyRequirement *= 0.6;
        }
        else if (this.modeType == "Energy")
        {
            energyRequirement = 0;
        }

        this.totalEnergyStored += energyProvided;
        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {energyProvided}");
        sb.Append($"Plumbus Ore Mined: ");

        if (energyRequirement > this.totalEnergyStored)
        {
            sb.Append("0");
        }
        else
        {
            var oreMined = this.harvesters.Sum(harvester => harvester.OreOutput);

            if (this.modeType == "Half")
            {
                oreMined /= 2;
            }
            else if (this.modeType == "Energy")
            {
                oreMined = 0;
            }

            this.totalOrStored += oreMined;
            this.totalEnergyStored -= energyRequirement;
            sb.Append(oreMined);
        }

        return sb.ToString().Trim();
    }

    public string GetShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalOrStored}");

        return sb.ToString().Trim();
    }
}