using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Tools
{
    internal static class StringExtension
    {
        internal static byte[] Hash(this string? value)
        {
            if(value is null)
                return Array.Empty<byte>();

            return SHA512.HashData(Encoding.Default.GetBytes(value));
        }
    }
}
