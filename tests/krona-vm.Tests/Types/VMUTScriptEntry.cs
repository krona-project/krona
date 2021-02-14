using Krona.Test.Converters;
using Newtonsoft.Json;

namespace Krona.Test.Types
{
    public class VMUTScriptEntry
    {
        [JsonProperty, JsonConverter(typeof(ScriptConverter))]
        public byte[] Script { get; set; }
    }
}