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
            if (!Int32.TryParse(Id, out int number))
                return "Invalid ID. ID must be a number!";
            if (Id.Length == 3)
                return "100" + Id;
            else if (Id.Length == 4)
                return "10" + Id;
            else
                return "Invalid ID. ID must be 3 or 4 digits!";
        }
    }
}
