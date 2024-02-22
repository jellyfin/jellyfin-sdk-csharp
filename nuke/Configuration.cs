using System.ComponentModel;
using Nuke.Common.Tooling;

[TypeConverter(typeof(TypeConverter<Configuration>))]
public class Configuration : Enumeration
{
    public static Configuration Stable = new() { Value = nameof(Stable) };
    public static Configuration Unstable = new() { Value = nameof(Unstable) };

    public static implicit operator string(Configuration configuration)
    {
        return configuration.Value;
    }
}
