using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber.Validator.Extensions
{
    public static class PhoneNumberValidatorExtensions
    {
        public static bool IsValidMobilisNumber(this IPhoneNumber phoneNumber)
        {
            return phoneNumber
                .WithMask("002136########")
                .WithMask("+2136########")
                .IsValid();
        }

        public static bool IsValidDjezzyNumber(this IPhoneNumber phoneNumber)
        {
            return phoneNumber
                .WithMask("002137########")
                .WithMask("+2137########")
                .IsValid();
        }

        public static bool IsValidOoredooNumber(this IPhoneNumber phoneNumber)
        {
            return phoneNumber
                .WithMask("002135########")
                .WithMask("+2135########")
                .IsValid();
        }
    }
}
