using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IOrchestrationService
    {
        string FetchInternalId(string Id);
    }
}
