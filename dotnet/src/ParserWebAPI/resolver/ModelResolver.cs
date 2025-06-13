
using DTDLParser.Models;
using DTDLParser;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom.Compiler;
using System.Drawing.Printing;
using ParserWebAPI.models;

namespace ParserWebAPI.resolver
{
    public class ModelResolver
    {
        private Dictionary<Dtmi, string> modelsDefinitions = new Dictionary<Dtmi, string>();
        private DTDLSpecificationContext context;

        public ModelResolver(DTDLSpecificationContext _context)
        {
            // Initialize the model definitions dictionary if needed
            modelsDefinitions = new Dictionary<Dtmi, string>();
            this.context = _context;
        }

        private async IAsyncEnumerable<string> GetJsonTexts(IReadOnlyCollection<Dtmi> dtmis, Dictionary<Dtmi, string> jsonTexts)
        {


            foreach (Dtmi dtmi in dtmis)
            {
                var dtdlSpecification = context.DTDLSpecifications.FirstOrDefault(m => m.id == dtmi.AbsoluteUri.ToString());
                var id = dtmi.AbsoluteUri.ToString();
                if (dtdlSpecification is not null)
                {
                    yield return dtdlSpecification.specification.ToString();
                }
            }
        }

        public async Task<DTInterfaceInfo> LoadModelAsyncFromString(string dtmi, string dtdl)
        {
            var id = new Dtmi(dtmi);
            
            context.AddOrUpdateSpecification(dtmi, dtdl);

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