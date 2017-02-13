namespace DotNetExtensions
{

    using System;
    using System.IO;
    using System.Security.Cryptography;

    public static class StreamExtensions
    {

        public static string ConvertToString(this Stream stream)
        {
            stream.Position = 0;

            return new StreamReader(stream).ReadToEnd();
        }

        public static string GetMD5(this Stream stream)
        {
            stream.Position = 0;

            var arrayByteHashValue = new MD5CryptoServiceProvider().ComputeHash(stream);

            return BitConverter.ToString(arrayByteHashValue).Replace("-", String.Empty).ToLower();
        }

    }

}