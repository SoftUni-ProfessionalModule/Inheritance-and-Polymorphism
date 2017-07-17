using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;
    protected bool isSuccessfulRegistered;
    private string reasson;

    protected Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
        this.isSuccessfulRegistered = true;
        this.reasson = string.Empty;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }

        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }

            this.energyOutput = value;
        }
    }

    public string Id
    {
        get { return this.id; }
    }

    public override string ToString()
    {
        return $"Provider - {this.id}";
    }

    public virtual string PrintCheck()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Provider - {this.id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");

        return sb.ToString().Trim();
    }
}