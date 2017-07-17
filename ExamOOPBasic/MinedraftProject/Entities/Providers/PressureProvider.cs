public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput *= 1.5;//Check!!!
    }

    public override string ToString()
    {
        return $"Successfully registered Pressure {base.ToString()}";
    }

    public override string PrintCheck()
    {
        return $"Pressure {base.PrintCheck()}";
    }
}