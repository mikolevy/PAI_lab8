using System.Collections.Generic;
using System.ServiceModel;
using AbonentService.Model;
using Library;

namespace AbonentService.Interfaces
{
    [ServiceContract]
    public interface IAbonentServiceClass : IMyLabService
    {
        [OperationContract]
        List<Abonent> GetAbonents();

        [OperationContract]
        void IncreaseSaldo();
    }
}