using System.Linq;


List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "9AF876", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
    new Customer(2, "John", "Doe", "3UM760", 19.95m),
  };

var customerGroups =
    from customer in customers
    group customer by customer.LastPurchasedSku into customerGp
    select customerGp;

foreach (var group in customerGroups)
{
    Console.WriteLine(group.Key);

    foreach (var customer in group)
      Console.WriteLine($"    {customer.FirstName} {customer.LastName}");
}

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);
