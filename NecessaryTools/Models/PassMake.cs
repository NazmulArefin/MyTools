using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;

namespace NecessaryTools.Models
{
    public class PassMake
    {
        [DisplayName(@"Enter Password:")]
        public string Password { get; set; }
        [DisplayName(@"Auto Generated Password:")]
        public string AutoGenePass { get; set; }

        public PassMake(string pass)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(pass);
            foreach (byte b in ascii)
            {
                int dec = b + 13;
                AutoGenePass += (dec > 126)
                    ? Convert.ToChar(32 + (dec - 126)).ToString()
                    : Convert.ToChar(dec).ToString();
            }
        }

        public class GtrPassword
        {
            [DisplayName(@"Enter Encripted Password:")]
            public string EncriptedPass { get; set; }
            [DisplayName(@"Real Password")]
            public string RealPass { get; set; }

            public GtrPassword(string pass)
            {
                byte[] ascii = Encoding.ASCII.GetBytes(pass);
                foreach (byte b in ascii)
                {
                    int dec = b - 13;
                    RealPass += Convert.ToChar(dec).ToString();
                }
            }
        }
    }
}