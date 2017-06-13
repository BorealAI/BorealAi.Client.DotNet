using BorealAI.Client.Models;

namespace BorealAI.Client.Requests
{
    public abstract class BorealAiFluentRequest : IBorealAiFluentRequest
    {
        protected readonly BorealAiRequest _request;

        protected BorealAiFluentRequest(BorealAiRequest request)
        {
            _request = request;
        }

        public BorealAiRequest GetRequestBody()
        {
            return _request;
        }

        public IBorealAiFluentRequest WithEntity(string entityName, string entityValue)
        {
            _request.Entities.Add(
                new BorealAiRequestEntity
                {
                    EntityName = entityName,
                    EntityValue = entityValue
                });

            return this;
        }

        public IBorealAiFluentRequest WithContext(string contextName, string contextValue)
        {
            _request.ContextData.Add(new BorealAiContext
            {
                ContextName = contextName,
                ContextValue = contextValue
            });
            return this;
        }

        public IBorealAiFluentRequest WithOptionalContext(string contextName, string contextValue)
        {
            _request.ContextData.Add(new BorealAiContext
            {
                ContextName = contextName,
                ContextValue = contextValue,
                IsOptional = true
            });
            return this;
        }
    }
}
