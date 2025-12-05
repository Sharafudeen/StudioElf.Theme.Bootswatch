using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudioElf.Theme.Bootswatch.Client;

public class BootswatchContainerSettings
{
    public const string SETTINGS_KEY = "StudioElf.Theme.Bootswatch.Container";

    public bool Title { get; set; } = true;
    public string Background { get; set; } = "";
    public string Text { get; set; } = "";
    public string Border { get; set; } = "";

    [JsonIgnore]
    public string Serialized { get; set; } = "{}";

    public BootswatchContainerSettings() { }

    public BootswatchContainerSettings(string json)
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                var loaded = JsonSerializer.Deserialize<BootswatchContainerSettings>(json);
                if (loaded != null)
                {
                    Title = loaded.Title;
                    Background = loaded.Background;
                    Text = loaded.Text;
                    Border = loaded.Border;
                }
                Serialized = json;
            }
            else
            {
                Serialized = "{}";
            }
        }
        catch
        {
            Serialized = "{}";
        }
    }

    public string ToJson() =>
        JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = false });

    public void Sync() =>
        Serialized = ToJson();

    public static BootswatchContainerSettings FromJson(string json) =>
        new BootswatchContainerSettings(json);
}
