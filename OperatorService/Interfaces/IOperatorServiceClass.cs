using System.Collections.Generic;
using System.ServiceModel;
using Library;
using OperatorService.Model;

namespace OperatorService.Interfaces
{
    [ServiceContract]
    public interface IOperatorServiceClass : IMyLabService
    {
        [OperationContract]
        List<PhoneOperatorData> GetOperatorData();
    }
}