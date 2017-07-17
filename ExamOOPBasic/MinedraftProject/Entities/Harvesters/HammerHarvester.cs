public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirment)
        : base(id, oreOutput, energyRequirment)
    {
        this.OreOutput += this.OreOutput * 2;//check!!!
        this.EnergyRequirment *= 2;//check!!!
    }

    public override string ToString()
    {
        return $"Successfully registered Hammer {base.ToString()}";
    }

    public override string PrintCheck()
    {
        return $"Hammer {base.PrintCheck()}";
    }
}