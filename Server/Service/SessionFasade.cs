using System.Collections.Generic;
using System.Linq;
using Server.AbonentServNamespace;
using Server.DataModel;
using Server.Interfaces;
using Server.OperatorServNamespace;
using Server.Utils;

namespace Server.Service
{
    public class SessionFasade : ISessionFasade
    {
        private readonly ServiceLocator _serviceLocator;

        public SessionFasade()
        {
            _serviceLocator = ServiceLocator.GetInstance();
        }

        public List<AbonentData> GetAbonentsData()
        {
            var abonentsServiceClient = (AbonentServiceClassClient)_serviceLocator.GetService(ServiceLocator.ServiceTypeAbonent);
            var operatorServiceClient =
                (OperatorServiceClassClient) _serviceLocator.GetService(ServiceLocator.ServiceTypeOperator);

            var abonents = abonentsServiceClient.GetAbonents();
            var phoneOperators = operatorServiceClient.GetOperatorData();
            var abonentsData = new List<AbonentData>();

            foreach (var abonent in abonents)
            {
                var phoneOperator = phoneOperators.FirstOrDefault(o => o.Id == abonent.PhoneOperatorId);
                var abonentData = new AbonentData(abonent.Name, abonent.PhoneNumber, abonent.Id, phoneOperator);
                abonentsData.Add(abonentData);
            }

            return abonentsData;
        }

        public void IncreaseSaldo()
        {
            var abonentsServiceClient =
                (AbonentServiceClassClient) _serviceLocator.GetService(ServiceLocator.ServiceTypeAbonent);
            abonentsServiceClient.IncreaseSaldo();
        }
    }
}