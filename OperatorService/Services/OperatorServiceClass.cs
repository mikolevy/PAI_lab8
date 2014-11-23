using System.Collections.Generic;
using OperatorService.Interfaces;
using OperatorService.Model;

namespace OperatorService.Services
{
    public class OperatorServiceClass : IOperatorServiceClass
    {
        public List<PhoneOperatorData> GetOperatorData()
        {
            return mockOperatorData();
        }

        private List<PhoneOperatorData> mockOperatorData()
        {
            var operators = new List<PhoneOperatorData>()
            {
                new PhoneOperatorData(1, "Orange", "ORG"),
                new PhoneOperatorData(2, "Play", "PLA"),
                new PhoneOperatorData(3, "T-mobile", "TMOB")
            };
            return operators;
        }
    }
}