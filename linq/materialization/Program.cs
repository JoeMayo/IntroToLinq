using System.Linq;

List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
  };

Console.WriteLine("\nNon-Materialized Query:\n");

var nonMaterialized =
    from customer in customers
    select customer;

// foreach materializes
foreach (var customer in nonMaterialized)
    Console.WriteLine(customer);

Console.WriteLine("\nMaterialized with ToList:\n");

List<Customer> materialized =
    (from customer in customers
     select customer)
    .ToList();

// already materialized
foreach (var customer in materialized)
    Console.WriteLine(customer);


Console.WriteLine("\nMaterialized with Count:\n");

int customerCount =
    (from customer in customers
     select customer)
    .Count();

Console.WriteLine(customerCount);

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);
