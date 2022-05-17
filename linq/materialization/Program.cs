using System.Linq;

List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
  };

Console.WriteLine("\nNon-Materialized:\n");

var nonMaterialized =
    from customer in customers
    select customer;

Console.WriteLine(nonMaterialized.GetType().FullName);

Console.WriteLine("\nMaterialized:\n");

List<Customer> materialized =
    (from customer in customers
     select customer)
    .ToList();

Console.WriteLine(materialized.GetType().FullName);

Console.WriteLine("\nNon-Materialized Anonmymous:\n");

var nonMaterializedAnonymous =
    from customer in customers
    select new
    {
        customer.ID,
        customer.FirstName,
        customer.LastName
    };

Console.WriteLine(nonMaterializedAnonymous.GetType().FullName);

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);
