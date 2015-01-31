namespace Guestbook.API.Tools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public static class HttpContextExtensions
    {
        private const string CookieName = "Guestbook_CAPTCHA";

        private const string Password = "jPdUgVU92LNEU92yhdhdmFbX3Df45PmjZ6wRqNj8";
        private const string Salt = "ZsZCeGaYbya8aPYCRjzt2WRR4H6wKvnDeCACrN7g";

        public static void SaveCaptcha(this HttpResponseMessage response, string captchaText)
        {
            var encryptedCode = RijndaelEncryptDecrypt.EncryptDecryptUtils.Encrypt(captchaText, Password, Salt, "SHA1");
            response.Headers.AddCookies(new List<CookieHeaderValue> { new CookieHeaderValue(CookieName, encryptedCode) });
        }

        public static bool ValidateCaptcha(this HttpRequestMessage request, string captchaText)
        {
            try
            {
                var captcha = request.Headers.GetCookies(CookieName);
                if (captcha == null || captcha.Count == 0 || captcha[0].Cookies.Count == 0)
                {
                    return false;
                }

                var encryptedCode = captcha.First().Cookies[0].Value;
                var decryptedCode = RijndaelEncryptDecrypt.EncryptDecryptUtils.Decrypt(encryptedCode, Password, Salt, "SHA1");

                var result = decryptedCode.Equals(captchaText);
                if (result)
                {
                    captcha[0].Expires = DateTime.Now.AddDays(-1d);
                }

                return result;

            }
            catch
            {
                return false;
            }
        }
    }
}