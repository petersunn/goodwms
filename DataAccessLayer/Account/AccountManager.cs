using DatabaseConnect;
using IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Account
{
    public class AccountManager : IAccountManager
    {
        public bool ValidateUserAccount(string UserName, string Password)
        {
            Database db = new Database();
            var user = db.Users.FirstOrDefault(c => c.UserName == UserName && c.Password == Password);
            if (user != null)
                return true;
            else
                return false;
        }
    }
}
