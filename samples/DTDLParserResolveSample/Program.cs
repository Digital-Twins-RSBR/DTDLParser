using DTDLParserResolveSample;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string basePath = Path.Join(System.Reflection.Assembly.GetExecutingAssembly().Location + @"./../../../../");


        var example1 = await ModelResolver.LoadModelAsync("dtmi:com:example;1", basePath);

        Console.WriteLine(example1.Print(true));
        foreach (var co in example1.Components)
            Console.WriteLine(
                $"[Co] {co.Value.Name} ({co.Value.Schema.Id}) \n" +
                  $"{co.Value.Schema.Print()}\n");

        //await parseModelAsync("dtmi:housegen:House;1", basePath);

        //await parseModelAsync("dtmi:housegen:Room;1", basePath);


        //await parseModelAsync("dtmi:housegen:LightBulb;1", basePath);


        // await parseModelAsync("dtmi:housegen:AirConditioner;1", basePath);

        string dtdl = @"{  ""@context"": [ ""dtmi:dtdl:context;3"", ""dtmi:dtdl:extension:quantitativeTypes;1"", ""dtmi:dtdl:extension:historization;1"" ],
              ""@id"": ""dtmi:housegen:Room;1"",
              ""@type"": ""Interface"",
              ""displayName"": ""Room"",
              ""contents"": [
                {
                  ""@type"": [ ""Property"", ""Area"" ],
                  ""name"": ""size"",
                  ""schema"": ""double"",
                  ""writable"": true,
                  ""unit"": ""squareFoot""
                },
                {
                  ""@type"": [ ""Telemetry"", ""Historized"" ],
                  ""name"": ""temperature"",
                  ""schema"": ""double""
                },
                {
                  ""@type"": ""Relationship"",
                  ""name"": ""lights"",
                  ""minMultiplicity"": 0,
                  ""maxMultiplicity"": 5,
                  ""target"": ""dtmi:housegen:LightBulb;1""
                },
                {
                  ""@type"": ""Relationship"",
                  ""name"": ""airconditioner"",
                  ""minMultiplicity"": 0,
                  ""maxMultiplicity"": 1,
                  ""target"": ""dtmi:housegen:AirConditioner;1""
                }
              ]}";

        await parseModelAsyncFromString("dtmi:housegen:Room;1", dtdl);

        static async Task parseModelAsync(string dtmi, string basePath)
        {
            var model = await ModelResolver.LoadModelAsync(dtmi, basePath);

            // Console.WriteLine(model.Print(true));

            Console.WriteLine("Propriedades");
            foreach( var prop in model.Properties)
            {
                var supType = prop.Value.SupplementalTypes.Count <= 0 ? "N" : prop.Value.SupplementalTypes.Single().ToString();
                Console.WriteLine($"[P] {prop.Value.Name} - {prop.Value.Schema.EntityKind} - {supType}\n");
            }
            Console.WriteLine("Telemetria");
            foreach(var tel in model.Telemetries)
            {
                Console.WriteLine($"[T] {tel.Value.Name} - {tel.Value.Schema.EntityKind} - {tel.Value.SupplementalTypes.Single()}");
            }

            Console.WriteLine("Relacionamentos");
            foreach (var tel in model.Relationships)
            {
                Console.WriteLine($"[R] {tel.Value.Name} - {tel.Value.Target}");
            }

            foreach (var co in model.Components)
                Console.WriteLine(
                    $"[Co] {co.Value.Name} ({co.Value.Schema.Id}) \n" +
                      $"{co.Value.Schema.Print()}\n");
        }
    }

    static async Task parseModelAsyncFromString(string dtmi, string dtdl)
    {
        var model = await ModelResolver.LoadModelAsyncFromString(dtmi, dtdl);

        // Console.WriteLine(model.Print(true));

        Console.WriteLine("Propriedades");
        foreach (var prop in model.Properties)
        {
            var supType = prop.Value.SupplementalTypes.Count <= 0 ? "N" : prop.Value.SupplementalTypes.Single().ToString();
            Console.WriteLine($"[P] {prop.Value.Name} - {prop.Value.Schema.EntityKind} - {supType}\n");
        }
        Console.WriteLine("Telemetria");
        foreach (var tel in model.Telemetries)
        {
            Console.WriteLine($"[T] {tel.Value.Name} - {tel.Value.Schema.EntityKind} - {tel.Value.SupplementalTypes.Single()}");
        }

        Console.WriteLine("Relacionamentos");
        foreach (var tel in model.Relationships)
        {
            Console.WriteLine($"[R] {tel.Value.Name} - {tel.Value.Target}");
        }

        foreach (var co in model.Components)
            Console.WriteLine(
                $"[Co] {co.Value.Name} ({co.Value.Schema.Id}) \n" +
                  $"{co.Value.Schema.Print()}\n");
    }
}