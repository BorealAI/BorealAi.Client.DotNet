using System.Collections.Generic;
using BorealAI.Client.Models;

namespace BorealAI.Client.Requests
{
    public class BorealAiRequestGreetings : BorealAiFluentRequest
    {
        public BorealAiRequestGreetings() 
            : base(new BorealAiRequest(BorealAiConsts.GreetingsIntent))
        {
        }

        /// <summary>
        /// Adds user name to the greetings request. Note that only a single user name can be currenty pass
        /// to the service so in case of calling this method multiple times - only last user name will be used.
        /// </summary>
        public BorealAiRequestGreetings WithUserName(string userName)
        {
            _request.Entities = new List<BorealAiRequestEntity>
            {
                new BorealAiRequestEntity
                {
                    EntityName = BorealAiConsts.GreetingsEntityUserName,
                    EntityValue = userName
                }
            };

            return this;
        }
    }
}
