
using Spectre.Console;
using VogenTest4;

// level 2: value objects with validation
// Potenial for error: lower
static void GreetCustomerOrder(CustomerId customerId, OrderId orderId, string message)
{
    AnsiConsole.MarkupLine($"Customer [red]{customerId}[/] has order [blue]{orderId}[/] with message: [green]{message}[/]");
}

AnsiConsole.MarkupLine("VoGen test, four");

// correct
GreetCustomerOrder(CustomerId.From("01234"), OrderId.From("00AABB01C2D"), "Congratulations on your correct order");
GreetCustomerOrder(CustomerId.From(Guid.NewGuid()), OrderId.From("00AABB01C2D"), "Congratulations on your correct order");

// throws
//GreetCustomerOrder(CustomerId.From(Guid.Empty), OrderId.From("00AABB01C2D"), "Congratulations on your order");


var guidId = CustomerId.From(Guid.NewGuid());
var guid = guidId.ToGuid();