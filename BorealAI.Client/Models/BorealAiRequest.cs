using System.Collections.Generic;
using Newtonsoft.Json;

namespace BorealAI.Client.Models
{
    public class BorealAiRequest
    {
        public BorealAiRequest() { }

        public BorealAiRequest(string intentName)
        {
            IntentName = intentName;
        }

        [JsonProperty("intentName")]
        public string IntentName { get; set; }

        [JsonProperty("entities")]
        public List<BorealAiRequestEntity> Entities { get; set; } = new List<BorealAiRequestEntity>();

        [JsonProperty("contextData")]
        public List<BorealAiContext> ContextData { get; set; } = new List<BorealAiContext>();
    }
}
