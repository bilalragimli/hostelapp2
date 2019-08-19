using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HostelApp
{
    public static class Extension
    {
        public static bool CheckInput(string[] arr,string emp)
        {
            foreach(var list in arr)
            {
                if(list==emp)
                {
                    return false;
                }
            }
            return true;
        }

        public static string HashMe(this string password)
        {
            byte[] byteArr = new ASCIIEncoding().GetBytes(password);
            byte[] hashArr = new SHA256Managed().ComputeHash(byteArr);
            string hashedPassword = new ASCIIEncoding().GetString(hashArr);
            return hashedPassword;
        }
    }
}
