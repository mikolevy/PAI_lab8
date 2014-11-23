using System.Runtime.Serialization;
using System.ServiceModel;
using Server.OperatorServNamespace;

namespace Server.DataModel
{
    [DataContract]
    public class AbonentData
    {
        public AbonentData(string name, string phoneNumber, int id, PhoneOperatorData phoneOperatorData)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Id = id;
            PhoneOperatorData = phoneOperatorData;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public PhoneOperatorData PhoneOperatorData { get; set; }
    }
}