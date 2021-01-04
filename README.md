# PhoneNumberValidator
Simple and Fluent API style Phone number validator, can be extended with many masks or formats.

# Usage
```Csharp
 var isValidMobilisNumber =  new PhoneNumberValidator()
                                .FromString("0662000000")
                                  .WithMask("002136########")
                                  .WithMask("+2136########")
                                .IsValid();
```
Or by using the builting extensions for algerian phone numbers operators (Djezzy, Mobiliss and Ooredoo)

```CSharp
var isValidDjezzyNumber = new PhoneNumberValidator()
                              .FromString("+213(0)770000000")
                              .IsValidDjezzyNumber();
```

Also anothe available option to indicate if the number is optional to accept the empty strings, by default the number is required.

```Csharp
 var isValidMobilisNumber =  new PhoneNumberValidator()
                                .FromString("0662000000")
                                  .IsOptional()
                                  .WithMask("002136########")
                                  .WithMask("+2136########")
                                .IsValid();
```

## Contribution
Contributions are welcome to make this repository better.

## Credits
Gives credits to [@cherifGsoul](https://github.com/cherifGsoul), his repository [php-algerian-mobile-phone-number](https://github.com/cherifGsoul/php-algerian-mobile-phone-number)
inspired me to create similar idear for .Net community.
