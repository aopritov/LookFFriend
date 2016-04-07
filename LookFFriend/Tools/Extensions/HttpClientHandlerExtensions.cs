using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace Tools.Extensions
{
    public static class HttpClientHandlerExtensions
    {
        public static void SetCookies(this HttpClientHandler handler, String cookies)
        {
            string pattern = @"(.+?)(?:=(.+?))?(?:;|$|,(?!\s))";
            handler.CookieContainer = new CookieContainer();
            if (!String.IsNullOrEmpty(cookies))
            {
                MatchCollection matches = Regex.Matches(cookies, pattern);
                foreach (Match match in matches)
                {
                    string name = match.Groups[0].Value;
                    string value = match.Groups[1].Value;
                    string value2 = match.Groups[2].Value;
                    handler.CookieContainer.Add(new Cookie(match.Groups[1].Value, match.Groups[2].Value));
                }
            }
        }
    }
}
