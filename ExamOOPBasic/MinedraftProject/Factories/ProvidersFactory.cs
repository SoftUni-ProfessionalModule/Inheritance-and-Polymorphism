using System.Collections.Generic;

public class ProvidersFactory
{
    public Provider RegProvider(List<string> parameters)
    {
        Provider provider = null;

        var providerType = parameters[0];
        parameters.RemoveAt(0);

        switch (providerType)
        {
            case "Pressure":
                provider = new PressureProvider(parameters[0], double.Parse(parameters[1]));
                break;
            case "Solar":
                provider = new SolarProvider(parameters[0], double.Parse(parameters[1]));
                break;
        }

        return provider;
    }
}