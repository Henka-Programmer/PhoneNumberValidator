using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

[assembly: InternalsVisibleTo("PhoneNumberValidator.Tests")]
namespace PhoneNumber.Validator.Extensions
{
    internal static class StringExtensions
    {
        public static string Mask(this string value, string mask, char substituteChar = '#')
        {
            int valueIndex = 0;
            var r = string.Empty;
            try
            {
                //return new string(mask.Select(maskChar => maskChar == substituteChar ? value[valueIndex++] : maskChar).ToArray());
                foreach (var c in mask)
                {
                    if (c == substituteChar)
                    {
                        r += value[valueIndex++];
                    }
                    else
                    {
                        r += c;
                        if (c == value[valueIndex])
                        {
                            valueIndex++;
                        }
                    }
                }
                return r;
            }
            catch (IndexOutOfRangeException e)
            {
                //throw new Exception("Value too short to substitute all substitute characters in the mask", e);
                return r;
            }
        }


        /// <summary>
        /// Removes all non numeric characters from a string
        /// </summary> 
        public static string RemoveNonNumeric(this string phoneNumber)
        {
            return Regex.Replace(phoneNumber, @"[^0-9#]+", "");
        }
    }
}
