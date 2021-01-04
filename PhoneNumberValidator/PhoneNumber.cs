using PhoneNumber.Validator.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumber.Validator
{
    class PhoneNumber : IPhoneNumber
    {
        private readonly HashSet<string> masks = new HashSet<string>();

        private bool isRequired = true;
        private readonly string phoneNumber = string.Empty;

        public PhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(phoneNumber) && !isRequired)
            {
                return true;
            }

            if (string.IsNullOrEmpty(phoneNumber) & isRequired)
                return false;

            var cleaned = phoneNumber.RemoveNonNumeric();

            if (isRequired && cleaned.Length == 0)
            {
                return false;
            }

            return masks.Any(mask => ValidateMask(cleaned, mask));
        }

        /// <summary>
        /// Tryes applying the given mask on the cleaned number.
        /// </summary>
        /// <param name="cleanedPhoneNumber">the phone Number without non numeric chars</param>
        /// <param name="mask">the mask that will be applied and validated upon</param>
        private bool ValidateMask(string cleanedPhoneNumber, string mask)
        {
            return phoneNumber == cleanedPhoneNumber.Mask(mask);
        }

        public IPhoneNumber IsRequired()
        {
            isRequired = true;
            return this;
        }

        public IPhoneNumber IsOptional()
        {
            isRequired = false;
            return this;
        }

        public IPhoneNumber WithMask(string mask)
        {
            if (string.IsNullOrEmpty(mask))
            {
                throw new ArgumentException("Invalid mask value!");
            }
            masks.Add(mask);
            return this;
        }
    }
}
