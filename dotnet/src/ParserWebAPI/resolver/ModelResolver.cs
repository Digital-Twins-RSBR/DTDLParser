
using DTDLParser.Models;
using DTDLParser;

namespace ParserWebAPI.resolver
{
    public class ModelResolver
    {

        public static async Task<DTInterfaceInfo> LoadModelAsyncFromString(string dtmi, string dtdl)
        {
            var parser = new ModelParser();
            Console.WriteLine($"Parser version: {parser.GetType().Assembly.FullName}\n Resolving dtml id: {dtmi}");
            var id = new Dtmi(dtmi);
            var result = await parser.ParseAsync(dtdl);
            return (DTInterfaceInfo)result[id];
        }


    }
}