using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;

namespace ParserWebAPI.models
{
    /// <summary>
    /// Represents a DTDL Model specification.
    /// </summary>
    /// <remarks>
    /// This class is used to receive the necessary data to parse a DTDL Model
    /// </remarks>
    public class DTDLSpecification
    {
        /// <summary>
        /// Reresents a DTMI model Id. The DTMI should be compliant with https://azure.github.io/opendigitaltwins-dtdl/DTDL/v3/DTDL.v3.html#digital-twin-model-identifier
        /// </summary>
     
        public string id { get; set; }
        /// <summary>
        /// This object must have a DTDML Model specification in JSON format, compliant with the DTDL v3.0 specification. https://azure.github.io/opendigitaltwins-dtdl/DTDL/v3/DTDL.v3.html
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        public object specification { get; set; }
    }
}
