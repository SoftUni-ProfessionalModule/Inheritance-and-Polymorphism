public class SolarProvider : Provider
{
    public SolarProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
    }

    public override string ToString()
    {
        return $"Successfully registered Solar {base.ToString()}";
    }

    public override string PrintCheck()
    {
        return $"Solar {base.PrintCheck()}";
    }
}