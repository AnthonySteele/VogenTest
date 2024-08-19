using Vogen;

namespace VogenTest4;

/// <summary>
/// New requirement:
/// "While keeping compatibility with the existing system that gives us numeric customer ids,
/// we are integrating a new system that has GUID customer ids.
/// We need to support both"
/// Just keep them in strings? Or type and validate it?
/// Yes really, this could be a real requirement.
/// 
/// So the underlying value has to be "string" 
/// and it's hard to store another value sucha s Guid? in this object as well.
/// Must rely on parsing guids into / out of the string
/// </summary>
[ValueObject<string>]
public readonly partial struct CustomerId
{
    public static CustomerId From(Guid id) => From(id.ToString());

    public Guid? ToGuid()
    {
        if (Guid.TryParse(Value, out var result))
        {
            return result;
        }

        return null;
    }


    private static string NormalizeInput(string? input) => input?.Trim() ?? string.Empty;

    private static Validation Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return Validation.Invalid("Customer IDs must have a value");
        }

        if (Guid.TryParse(input, out var guidValue))
        {
            if (guidValue == Guid.Empty)
            {
                return Validation.Invalid("Customer GUID IDs must have a value");
            }

            return Validation.Ok;
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
