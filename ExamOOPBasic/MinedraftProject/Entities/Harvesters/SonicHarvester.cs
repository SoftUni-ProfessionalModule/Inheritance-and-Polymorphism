public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirment, int sonicFactor)
        : base(id, oreOutput, energyRequirment)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirment /= this.sonicFactor;//check!!!
    }

    public override string ToString()
    {
        return $"Successfully registered Sonic {base.ToString()}";
    }

    public override string PrintCheck()
    {
        return $"Sonic { base.PrintCheck()}";
    }
}