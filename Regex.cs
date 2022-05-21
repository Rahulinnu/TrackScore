using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TrackScoreExam
{
    public class Regex
    {
        public static string regex_phoneno = "^[6-9][0-9]{9}$";
        public static string regex_email = @"^[a-z A-Z 0-9 \- .]@?[a-z A-z]+(com)$";

        public static bool CheckePhoneno(string phoneno)
        {
            return Regex.IsMatch(phoneno, regex_phoneno);
        }

        public static bool Checkemail(string email)
        {
            return Regex.IsMatch(email, regex_email);
        }


    }
}
