using System.Runtime.Serialization;

namespace AbonentService.Model
{
    [DataContract]
    public class Abonent
    {
        public Abonent(string name, string phoneNumber, int id, int phoneOperatorId)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Id = id;
            PhoneOperatorId = phoneOperatorId;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int PhoneOperatorId { get; set; }
    }
}