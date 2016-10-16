using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceCompare.Components
{
    /*
     Just as we spoke, your code completely fulfills the requirements of the assignment.
     Alas, you did not put your heart into the meaning of this excercise, which is designing a software system.
     Which is understandable, considering all.
         */
    public static class ChainInformation
    {
        public static string Vicotry => "7290696200003";
        public static string Shouk => "7290661400001";
        public static string Lahav => "7290058179503";

        public static string GetChainName(string chainId)
        {
            switch (chainId)
            {
                case "7290696200003":
                    return "ויקטורי: ";
                case "7290661400001":
                    return "מחסני השוק: ";
                case "7290058179503":
                    return "מחסני להב: ";
            }
            return "לא נמצאה רשת במספר זה.";
        }
    }
}
