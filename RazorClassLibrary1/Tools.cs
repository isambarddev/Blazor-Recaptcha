using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCaptcha
{
    public class Tools
    {

        const string CHARS = "ABCDEFGHJKLMNPQRSTUWYZabcdefghijkmnpqrstuwz23456789*#!$%=";

        public static string GetCaptchaWord(int length)
        {

            var random = new Random(DateTime.Now.Millisecond);
            string result = new(Enumerable.Repeat(CHARS, length)
                        .Select(s => s[random.Next(s.Length)])
                        .ToArray());

            return result;
        }

    }

}
