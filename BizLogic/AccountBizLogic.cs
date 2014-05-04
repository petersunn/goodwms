using DataAccessLayer.Account;
using IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class AccountBizLogic
    {
        public bool ValidateAccount(string UserName, string Password)
        {
            IAccountManager account = new AccountManager();
            return account.ValidateUserAccount(UserName, Password);
        }
    }
}
