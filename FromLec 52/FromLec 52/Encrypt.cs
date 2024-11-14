using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLec_52
{
    internal class Encrypt
    {
        private static readonly string allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly string N_allChar = "qwert0yui1op2ASDFG3HJKL4zxcvb5nmQWE6RTYUIOP7asdf8ghjkl9MZNXBCV";

        public static string Encrypt0(string Password)
        {
            var sb=new StringBuilder();
            foreach(char c in Password)
            {
                sb.Append(N_allChar[allChar.IndexOf(c)]);
            }
            return sb.ToString();
        }

        public static string Decrypt(string Password)
        {
            var sb = new StringBuilder();
            foreach (char c in Password)
            {
                sb.Append(allChar[N_allChar.IndexOf(c)]);
            }
            return sb.ToString();
        }


    }
}
