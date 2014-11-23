using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Server.DataModel;

namespace Server.Interfaces
{
    [ServiceContract]
    public interface ISessionFasade
    {
        [OperationContract]
        List<AbonentData> GetAbonentsData();

        [OperationContract]
        void IncreaseSaldo();
    }
}
