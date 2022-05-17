using System.Linq;

List<Customer> customers =
  new()
  {
    new Customer(1, "John", "Doe", "6DP824", 0.64m),
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
    new Customer(1, "Jane", "Smith", "1ON925", 157.91m),
  };

var filteredCustomers =
    from customer in customers
    where
      customer.LastPurchaseAmount > 5.0m &&
      customer.LastPurchaseAmount < 20m
    select customer;

foreach (var customer in filteredCustomers)
    Console.WriteLine(customer);

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);