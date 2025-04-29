
using DTDLParser.Models;
using DTDLParser;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom.Compiler;
using System.Drawing.Printing;

namespace ParserWebAPI.resolver
{
    public class ModelResolver
    {
        private Dictionary<Dtmi, string> modelsDefinitions = new Dictionary<Dtmi, string>();

        private async IAsyncEnumerable<string> GetJsonTexts(IReadOnlyCollection<Dtmi> dtmis, Dictionary<Dtmi, string> jsonTexts)
        {
            foreach (Dtmi dtmi in dtmis)
            {
                if (jsonTexts.TryGetValue(dtmi, out string refJsonText))
                {
                    yield return refJsonText;
                }
            }
        }

        public async Task<DTInterfaceInfo> LoadModelAsyncFromString(string dtmi, string dtdl)
        {
            var id = new Dtmi(dtmi);
            modelsDefinitions[id] = dtdl;
            Console.WriteLine(modelsDefinitions);
            var parser = new ModelParser(new ParsingOptions
            {
                DtmiResolverAsync = (IReadOnlyCollection<Dtmi> dtmis, CancellationToken _) =>
                {
                    return GetJsonTexts(dtmis, modelsDefinitions);
                }
            });

            Console.WriteLine($"Parser version: {parser.GetType().Assembly.FullName}\n Resolving dtml id: {dtmi}");
            var result = await parser.ParseAsync(dtdl);
            return (DTInterfaceInfo)result[id];
        }
    }
}