using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kethan.DevToys.Tailwind.ClosestColor;

internal class ClosestColorUtils
{
    public ClosestColorUtils()
    {
       LoadColors();
    }

    static void ClosestColor()
    {

    }

    static void LoadColors()
    {
        // Read the JSON file
        string jsonFilePath = "tailwind-colors.json";
        string jsonContent = File.ReadAllText(jsonFilePath);

        // Parse the JSON content
        using JsonDocument jsonDocument = JsonDocument.Parse(jsonContent);
        JsonElement root = jsonDocument.RootElement;

        // Flatten the JSON object
        Dictionary<string, string> flattenedDict = new Dictionary<string, string>();
        FlattenJson(root, "", flattenedDict);

        // Print the flattened dictionary
        foreach (var kvp in flattenedDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static void FlattenJson(JsonElement jsonElement, string prefix, Dictionary<string, string> flattenedDict)
    {
        foreach (var property in jsonElement.EnumerateObject())
        {
            string key = string.IsNullOrEmpty(prefix) ? property.Name : $"{prefix}-{property.Name}";

            if (property.Value.ValueKind == JsonValueKind.Object)
            {
                FlattenJson(property.Value, key, flattenedDict);
            }
            else if (property.Value.ValueKind == JsonValueKind.String)
            {
                flattenedDict[key] = property.Value.GetString() ?? "";
            }
            else
            {
                flattenedDict[key] = property.Value.ToString();
            }
        }
    }
}
