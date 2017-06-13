using System.Collections.Generic;
using Newtonsoft.Json;

namespace BorealAI.Client.Models
{
    public class BorealAiResponse
    {
        public BorealAiResponse() { }

        /// <summary>
        /// Contains a list of produced text responses.
        /// </summary>
        [JsonProperty("textResponses")]
        public List<string> TextResponses { get; set; } = new List<string>();

        [JsonProperty("schema")]
        public string Schema { get; set; } = "0.1";
    }
}
