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

        await parseModelAsync("dtmi:housegen:House;1", basePath);

        await parseModelAsync("dtmi:housegen:Room;1", basePath);


        await parseModelAsync("dtmi:housegen:LightBulb;1", basePath);


        await parseModelAsync("dtmi:housegen:AirConditioner;1", basePath);


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
}