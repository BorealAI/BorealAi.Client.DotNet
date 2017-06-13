using BorealAI.Client.Models;

namespace BorealAI.Client.Requests
{
    public class BorealAiRequestFromIntent : BorealAiFluentRequest
    {
        public BorealAiRequestFromIntent(string intentName) 
            : base(new BorealAiRequest(intentName))
        { }
    }
}
