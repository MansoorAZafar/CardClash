namespace CardClash.Models;

public class ConfigurationValue
{
    public string Url { get; }
    public ConfigurationValue(string url)
    {
        Url = url;
    }
}
