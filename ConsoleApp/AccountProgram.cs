using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class AccountProgram
    {
        static void Main(string[] args)
        {
            SavingBankAccount bankAccount = new SavingBankAccount();

            bankAccount.Configure(accountSetting =>
            {
                accountSetting.AccountStatus = AccountStatus.Active;
            });
        }
    }
}
