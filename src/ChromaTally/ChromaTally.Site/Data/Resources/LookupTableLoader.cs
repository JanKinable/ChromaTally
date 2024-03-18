using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using ChromaTally.Site.Data.Models;

namespace ChromaTally.Site.Data.Resources;

public static class LookupTableLoader
{
    static JsonSerializerOptions SerializationOptions = new JsonSerializerOptions
    {
        Converters = { new JsonStringEnumConverter() }
    };

    public static ILookupTable Load()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        var resourceFullName = "ChromaTally.Site.Data.Resources.LookupTable.json";
        using Stream? stream = assembly.GetManifestResourceStream(resourceFullName);
        if (stream == null)
        {
            throw new Exception($"Resource '{resourceFullName}' not found.");
        }

        // Deserialize JSON from the stream
        using StreamReader reader = new StreamReader(stream);
        string json = reader.ReadToEnd();

        LookupTable? lookupTable = JsonSerializer.Deserialize<LookupTable>(json, SerializationOptions);

        return lookupTable != null ? (ILookupTable)lookupTable : throw new Exception($"Resource '{resourceFullName}' unable to deserialize.");
    }
}