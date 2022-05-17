using System.Linq;

List<Customer> customers =
  new()
  {
    new Customer(1, "Sam", "Young"),
    new Customer(2, "Pat", "Smith"),
    new Customer(3, "Joe", "Mayo"),
  };
List<LastOrder> lastOrders =
  new()
  {
    new LastOrder(1, "8ER345", 16.25m),
    new LastOrder(2, "3UM760", 19.95m),
    new LastOrder(3, "9AF876", 13.79m),
  };

var customerOrders =
    from customer in customers
    join order in lastOrders on customer.ID equals order.ID
    select new {
      customer.ID,
      customer.FirstName,
      customer.LastName,
      order.LastPurchasedSku,
      order.LastPurchaseAmount
    };

foreach (var orders in customerOrders)
    Console.WriteLine(orders);

record Customer(
  int ID,
  string FirstName,
  string LastName);

record LastOrder(
  int ID,
  string LastPurchasedSku,
  decimal LastPurchaseAmount);