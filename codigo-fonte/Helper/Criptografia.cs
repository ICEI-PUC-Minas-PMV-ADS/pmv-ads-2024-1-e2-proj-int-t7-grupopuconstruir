using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace PUConstruir.Helper
{
    public static class Criptografia
    {
        public static string gerarHash(this string valor)
        {
            var hash = SHA1.Create();
            var encoding = new ASCIIEncoding();
            var array = encoding.GetBytes(valor);

            array = hash.ComputeHash(array);

            var strHash = new StringBuilder();

            foreach ( var item in array)
            {
                strHash.Append(item.ToString("x2"));
            }
            return strHash.ToString();
            
        }
    }
}
