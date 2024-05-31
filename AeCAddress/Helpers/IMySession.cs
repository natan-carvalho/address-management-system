using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeCAddress.Helpers
{
    public interface IMySession
    {
        void CreateSession(UserModel user);
        void RemoveSession();
        UserModel GetSession();
    }
}