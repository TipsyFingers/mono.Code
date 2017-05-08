using System.Text.RegularExpressions;

namespace mono.Code
{
    public class ValidationClass
    {

        public static bool validateString(string valStr)                    // provjera sadržava li string samo slova (ukljucujuci internacionalne znakove)
        {
            if (Regex.IsMatch(valStr, @"^[\p{L}]+$"))
                return true;
            else
                return false;
        }

        public static bool validateValueRng(decimal valDec)                 // provjera nalazi li se broj u intervalu [1,5]
        {
            if (valDec < 1 || valDec > 5)
            {
                return false;
            }
            else
                return true;
        }

    }
}
