using Krona.Test.Converters;
using Krona.VM;
using Newtonsoft.Json;

namespace Krona.Test.Types
{
    public class VMUTExecutionContextState
    {
        [JsonProperty, JsonConverter(typeof(ScriptConverter))]
        public byte[] ScriptHash { get; set; }

        [JsonProperty]
        public OpCode NextInstruction { get; set; }

        [JsonProperty]
        public int InstructionPointer { get; set; }

        // Stacks

        [JsonProperty]
        public VMUTStackItem[] AltStack { get; set; }

        [JsonProperty]
        public VMUTStackItem[] EvaluationStack { get; set; }
    }
}