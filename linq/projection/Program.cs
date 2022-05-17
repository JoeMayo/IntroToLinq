using System.Linq;


List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young", "8ER345", 16.25m),
    new Customer(2, "Pat", "Smith", "3UM760", 19.95m),
    new Customer(3, "Joe", "Mayo", "9AF876", 13.79m),
  };

var customerSummaries1 =
    from customer in customers
    select
      new CustomerSummary(
        $"{customer.FirstName} {customer.LastName}",
        customer.LastPurchasedSku,
        customer.LastPurchaseAmount);

foreach (var summary in customerSummaries1)
    Console.WriteLine(summary);

var customerSummaries2 =
    from customer in customers
    let name = $"{customer.FirstName} {customer.LastName}"
    let sku = customer.LastPurchasedSku
    let amount = customer.LastPurchaseAmount
    select new CustomerSummary(name, sku, amount);

foreach (var summary in customerSummaries2)
    Console.WriteLine(summary);

record Customer(
  int ID,
  string FirstName,
  string LastName,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);

record CustomerSummary(
  string Name,
  string SKU,
  decimal Amount
);