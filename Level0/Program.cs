
using Spectre.Console;

// level 0: using strings for every type
// Potenial for error: high
static void GreetCustomerOrder(string customerId, string orderId, string message)
{
    AnsiConsole.MarkupLine($"Customer [red]{customerId}[/] has order [blue]{orderId}[/] with message: [green]{message}[/]");
}

AnsiConsole.MarkupLine("VoGen test, zero: just strings");

// correct
GreetCustomerOrder("01234", "00AABB01C2D", "Congratulations on your correct order");

// not correct
GreetCustomerOrder("00AABB01C2D", "01234", "Congratulations on your order");
GreetCustomerOrder("01234",  "Congratulations on your order", "00AABB01C2D");
GreetCustomerOrder("", " ", "Congratulations on your order");
