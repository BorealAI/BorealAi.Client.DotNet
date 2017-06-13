using Newtonsoft.Json;

namespace BorealAI.Client.Models
{
    public class BorealAiRequestEntity
    {
        [JsonProperty("entityName")]
        public string EntityName { get; set; }

        [JsonProperty("entityValue")]
        public string EntityValue { get; set; }
    }
}
