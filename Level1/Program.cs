
using Spectre.Console;
using VogenTest1;

// level 1: value objects
// Potenial for error: medium
static void GreetCustomerOrder(CustomerId customerId, OrderId orderId, string message)
{
    AnsiConsole.MarkupLine($"Customer [red]{customerId}[/] has order [blue]{orderId}[/] with message: [green]{message}[/]");
}

AnsiConsole.MarkupLine("VoGen test, one: simple value objects");

// correct
GreetCustomerOrder(CustomerId.From("01234"), OrderId.From("00AABB01C2D"), "Congratulations on your correct order");

// not correct, does not compile
//GreetCustomerOrder(OrderId.From("00AABB01C2D"), CustomerId.From("01234"), "Congratulations on your order");
//GreetCustomerOrder(CustomerId.From("01234"), "Congratulations on your order", OrderId.From("00AABB01C2D"));

// not correct, does compile
GreetCustomerOrder(CustomerId.From("00AABB01C2D"), OrderId.From("01234"), "Congratulations on your order");
GreetCustomerOrder(CustomerId.From("01234"), OrderId.From("Congratulations on your order"), "00AABB01C2D");
GreetCustomerOrder(CustomerId.From(""), OrderId.From(" "), "Congratulations on your order");
