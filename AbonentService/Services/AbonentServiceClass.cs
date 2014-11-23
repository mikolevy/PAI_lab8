using System;
using System.Collections.Generic;
using AbonentService.Interfaces;
using AbonentService.Model;
using System.Threading;

namespace AbonentService.Services
{
    public class AbonentServiceClass : IAbonentServiceClass
    {
        public List<Abonent> GetAbonents()
        {
            return mockAbonents();
        }

        public void IncreaseSaldo()
        {
            mockIncreaseSaldo();
        }

        private List<Abonent> mockAbonents()
        {
            var abonents = new List<Abonent>()
            {
                new Abonent("Jan Kowalski", "123123123", 1, 1),
                new Abonent("Kuba Wojciechowski", "333444212", 2, 1),
                new Abonent("Krzysztof Nowak", "67892398", 3, 2),
                new Abonent("Kamila Nowak", "678543675", 3, 2),
                new Abonent("Franciszek Nowak", "746534543", 4, 2),
                new Abonent("Robert Weso³owski", "738794812", 5, 3)
            };
            return abonents;
        }

        private void mockIncreaseSaldo()
        {
            Thread.Sleep(3000);
        }
    }
}