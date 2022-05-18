using System.Linq;

List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
    new Customer(4, "Joe", "Mayo", "7ZZ777", 99.99m),
  };

List<Customer> potentialCustomers =
  new()
  {
    new Customer(1001, "John", "Doe", "", 0m),
    new Customer(1002, "Jane", "Smith", "", 0m),
  };

Console.WriteLine("\nDistinct: \n");

List<Customer> distinctCustomers =
    (from customer in customers
     select customer)
    .DistinctBy(c => new {c.FirstName, c.LastName})
    .ToList();

// already materialized
foreach (var customer in distinctCustomers)
    Console.WriteLine(customer);

Console.WriteLine("\nAverage Amount:\n");

decimal averageAmount =
    (from customer in distinctCustomers
     select customer.LastPurchaseAmount)
    .Average();

Console.WriteLine(averageAmount);


Console.WriteLine("\nUnion:\n");

var allCustomers = distinctCustomers.Union(potentialCustomers);

foreach (var customer in allCustomers)
    Console.WriteLine(customer);


record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);
