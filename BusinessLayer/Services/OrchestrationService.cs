using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class OrchestrationService : IOrchestrationService
    {
        private int number;
        public int FetchInternalId(string Id)
        {
            if (!Int32.TryParse(Id, out number) || number > 9999 || number < 100)
                throw new ArgumentException("Invalid Id.");
            return 100000 + number;
        }
    }
}
