using System;
using System.Security.Cryptography;
using System.Text;

namespace HashCodeGenerator
{
    public static class HashCodeGenerator
    {
        public static string GenerateHashCode(string input)
        {
            using (var algorithm = SHA256.Create())
            {
                byte[] hashBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
