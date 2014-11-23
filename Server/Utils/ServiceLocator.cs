using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using Server.AbonentServNamespace;
using Server.OperatorServNamespace;

namespace Server.Utils
{
    public class ServiceLocator
    {
        public const string ServiceTypeAbonent = "SERVICE_TYPE_ABONENT";
        public const string ServiceTypeOperator = "SERVICE_TYPE_OPERATOR";

        private AbonentServiceClassClient _abonentServiceClassClient;
        private OperatorServiceClassClient _operatorServiceClassClient;

        private static ServiceLocator _instance;

        public static ServiceLocator GetInstance()
        {
            if (null == _instance)
                _instance = new ServiceLocator();
            return _instance;
        }

        public Object GetService(string serviceType)
        {
            switch (serviceType)
            {
                case ServiceTypeAbonent:
                    if (null == _abonentServiceClassClient)
                        _abonentServiceClassClient = (AbonentServiceClassClient) CreateServiceProxy(serviceType);
                    return _abonentServiceClassClient;
                case ServiceTypeOperator:
                    if (null == _operatorServiceClassClient)
                        _operatorServiceClassClient = (OperatorServiceClassClient) CreateServiceProxy(serviceType);
                    return _operatorServiceClassClient;
                default:
                    throw new NotImplementedException();
            }
        }

        private Object CreateServiceProxy(string serviceType)
        {
            switch (serviceType)
            {
                case ServiceTypeAbonent:
                    return new AbonentServiceClassClient();
                case ServiceTypeOperator:
                    return new OperatorServiceClassClient();
                default:
                    throw new NotImplementedException();
            }
        }

        private ServiceLocator()
        {
        }
    }
}
