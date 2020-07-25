using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class OrchestrationService : IOrchestrationService
    {
        public string FetchInternalId(string Id)
        {
            if (Id.Length == 3)
                return "100" + Id;
            else if (Id.Length == 4)
                return "10" + Id;
            else
                throw new ArgumentException("Invalid ID");
        }
    }
}
