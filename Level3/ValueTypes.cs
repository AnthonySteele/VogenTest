using Spectre.Console;
using Vogen;

namespace VogenTest3;


[ValueObject<string>]
public readonly partial struct CustomerId
{
    private static string NormalizeInput(string? input) => input?.Trim() ?? string.Empty;

    private static Validation Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return Validation.Invalid("Customer IDs must have a value");
        }

        if (input.Any(ch => !char.IsAsciiDigit(ch)))
        {
            return Validation.Invalid("Customer IDs must only be numeric");
        }

        if (input.Length > 20)
        {
            return Validation.Invalid("Customer ID too long");
        }

        return Validation.Ok;
    }
}

[ValueObject<string>]
public readonly partial struct OrderId
{
    private static string NormalizeInput(string? input) => input?.Trim() ?? string.Empty;

    private static Validation Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return Validation.Invalid("Customer IDs must have a value");
        }

        if (input.Any(ch => !char.IsAsciiHexDigit(ch)))
        {
            return Validation.Invalid("Order IDs must only be hex");
        }

        if (input.Length > 30)
        {
            return Validation.Invalid("Order ID too long");
        }

        return Validation.Ok;
    }
}


[ValueObject<string>]
public readonly partial struct Message
{
    private static string NormalizeInput(string? input) => input?.Trim() ?? string.Empty;

    private static Validation Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return Validation.Invalid("Message must have a value");
        }

        if (input.Length > 2000)
        {
            return Validation.Invalid("Message too long");
        }

        return Validation.Ok;
    }
}