using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src
{
    public static class StringValidationExtensions
    {
        // 010/011/012/015 + 8 أرقام، أو +20 بدل الصفر
        private static readonly Regex PhonePattern =
            new(@"\A(?:\+20|0)1[0125][0-9]{8}\z");

        // 14 رقم بالظبط، أول رقم 2 أو 3
        private static readonly Regex NationalIdPattern =
            new(@"\A[23][0-9]{13}\z");

        public static bool IsValidEgyptianPhone(this string? value) =>
            !string.IsNullOrWhiteSpace(value) && PhonePattern.IsMatch(value);

        public static bool IsValidEgyptianNationalId(this string? value) =>
            !string.IsNullOrWhiteSpace(value) && NationalIdPattern.IsMatch(value);
    }
}
