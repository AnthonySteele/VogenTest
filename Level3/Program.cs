
using Spectre.Console;
using VogenTest3;

// level 3: even the test message is typed
static void GreetCustomerOrder(CustomerId customerId, OrderId orderId, Message message)
{
    AnsiConsole.MarkupLine($"Customer [red]{customerId}[/] has order [blue]{orderId}[/] with message: [green]{message}[/]");
}

AnsiConsole.MarkupLine("VoGen test, three: typed message");

// correct
GreetCustomerOrder(CustomerId.From("01234"), OrderId.From("00AABB01C2D"), (Message)"Congratulations on your correct order");

