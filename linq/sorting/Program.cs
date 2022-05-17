using System.Linq;


List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
  };

var customerSummaries1 =
    from customer in customers
    orderby customer.LastName
    select customer;

foreach (var summary in customerSummaries1)
    Console.WriteLine(summary);

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);
