using System.Text;
using Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Person> guest = new List<Person>();

Person p1 = new Person(name: "Hospede 1");
Person p2 = new Person(name: "Hospede 2 ");

guest.Add(p1);
guest.Add(p2);

Suite suite = new Suite(SuiteType: "Premium", Capacity: 2, PriceDay: 30);

Book book = new Book(reservedDays: 5);
book.RegisterSuite(suite);
book.RegisterGuest(guest);

Console.WriteLine($"Hospedes: {book.GetTotalGuests()}");
Console.WriteLine($"Valor diária: {book.GetValuePerDay()}");


