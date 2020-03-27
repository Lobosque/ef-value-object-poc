# Value Objects (as in DDD) and Ef Core

You can improve your Domain layer using Value Objects instead primitive types to represent data with constraints and other stuff, more about [the topic here.](https://refactoring.guru/smells/primitive-obsession).

The Value Object implementation was taken from this [excellent blog post](https://lostechies.com/jimmybogard/2007/12/03/dealing-with-primitive-obsession/).

This PoC creates a [Social Security Number](https://en.wikipedia.org/wiki/Social_Security_number) object and successfully configures EF Core to understand that this should be mapped to a string column in database. It is also able to query objects and deserialize data correctly into the Entities Classes.

However, how one would do very simple [query contitions such as LIKE](https://github.com/Lobosque/ef-value-object-poc/blob/master/Program.cs#L32)?

This PoC tries to achieve it by implementing the `Contains` method in the `Ssn` class, but it doesn't work.

Is there a specific way to instruct EF Core how to evaluate non-primitive types?

Any other suggestions on how this could be achieved? Please feel free to submit PR's or open issues to discuss