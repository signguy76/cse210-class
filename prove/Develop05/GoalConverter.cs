using System.Text.Json;
using System.Text.Json.Serialization;

// Custom converter to handle the polymorphic Goal class hierarchy
public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();
            string json = root.GetRawText();

            return type switch
            {
                "SimpleGoal" => JsonSerializer.Deserialize<SimpleGoal>(json, options),
                "EternalGoal" => JsonSerializer.Deserialize<EternalGoal>(json, options),
                "ChecklistGoal" => JsonSerializer.Deserialize<ChecklistGoal>(json, options),
                _ => throw new NotSupportedException($"Goal type {type} is not supported")
            };
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("Type", value.GetType().Name);
        foreach (var prop in value.GetType().GetProperties())
        {
            writer.WritePropertyName(prop.Name);
            JsonSerializer.Serialize(writer, prop.GetValue(value), prop.PropertyType, options);
        }

        writer.WriteEndObject();
    }
}
