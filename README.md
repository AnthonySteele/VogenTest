# VogenTest

Code sample trying out [Vogen](https://github.com/SteveDunn/Vogen) for Value Object generation.

In all cases the types are used in `Program.cs` and declared in `ValueTypes.cs`.

`Level0` just uses strings. It is a "before VoGen" baseline.

`Level1` changes over to basic Vogen types, no extras.

`Level2` also validates objects. 

I am interested in validation, for when all customer ids are strings, but not many strings are valid customer ids.

The rules for CustomerId and OerdId are intentionally different, so that validation failures can be shown.

In `Level3`  I am trying to push it further: A "message" is readable text, so it could be typed as just `string`. But also declaring a `Message` type lets you say that it's never null or empty, and set a max length. This demonstrates explicit casting from string to message.

In `level 4`, I try out a "requirements change" where CustomerId is a string containing numeric or guid data. Mixed success on this one.