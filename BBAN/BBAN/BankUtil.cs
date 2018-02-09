using System;
using System.Collections.Generic;
using System.Text;

namespace BBAN
{
    class BankUtil
    {
        public static string CorrectNumber(string accountNumber)
        {
            accountNumber = accountNumber.Replace("-", null);
            return "xx";
        }
    }
}
