using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Book
    {
        public List<Person> Guest { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Book()
        {
            Guest = new List<Person>();
        }
        public Book(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuest(List<Person> guest)
        {
            if (guest.Count <= Suite.Capacity)
            {
                Guest = guest;
            }
            else
            {
                throw new Exception("A quantidade de hospedes excede a capacidade da Suite");

            }
        }
        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetTotalGuests()
        {
            return Guest.Count;
        }

        public decimal GetValuePerDay()
        {
            decimal TotalValue = ReservedDays * Suite.PriceDay;
            if (ReservedDays >= 10)
            {
                TotalValue *= 0.90m; //10% discount
            }
            return TotalValue;
        }

        internal void RegisterSuite()
        {
            throw new NotImplementedException();
        }
    }
}