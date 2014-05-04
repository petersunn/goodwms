using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataAccessLayer
{
    public interface IAccountManager
    {
        bool ValidateUserAccount(string UserName, string Password);
    }
}
