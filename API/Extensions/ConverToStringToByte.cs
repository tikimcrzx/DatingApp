using System;

namespace API.Extensions
{
    public static class ConverToStringToByte
    {
        public static byte[] ToByteArray(this string value) =>
               Convert.FromBase64String(value);
    }
}