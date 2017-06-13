using BorealAI.Client.Models;

namespace BorealAI.Client
{
    public interface IBorealAiFluentRequest
    {
        BorealAiRequest GetRequestBody();

        IBorealAiFluentRequest WithEntity(string entityName, string entityValue);
    }
}
