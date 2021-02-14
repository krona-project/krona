using Newtonsoft.Json;

namespace Krona.Test.Types
{
    public class VMUTStep
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public VMUTActionType[] Actions { get; set; }

        [JsonProperty]
        public VMUTExecutionEngineState Result { get; set; }
    }
}