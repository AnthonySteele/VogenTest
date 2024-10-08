﻿using Vogen;

namespace VogenTest4;

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

        if (input.Length > 20)
        {
            return Validation.Invalid("Order ID too long");
        }

        return Validation.Ok;
    }
}
