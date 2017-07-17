using System;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirment;

    protected Harvester(string id, double oreOutput, double energyRequirment)
    {
        this.id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirment = energyRequirment;
    }

    public double OreOutput
    {
        get { return this.oreOutput; }

        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }

            this.oreOutput = value;
        }
    }

    public string Id
    {
        get { return this.id; }
    }

    public double EnergyRequirment
    {
        get { return this.energyRequirment; }

        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }

            this.energyRequirment = value;
        }
    }

    public override string ToString()
    {
        return $"Harvester - {this.id}";
    }

    public virtual string PrintCheck()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Harvester - {this.id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: { this.EnergyRequirment}");
        return sb.ToString().Trim();
    }
}