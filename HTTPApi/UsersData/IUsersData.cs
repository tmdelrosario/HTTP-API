using System;
using System.Collections.Generic;
using HTTPApi.Model;

namespace HTTPApi.UsersData
{
    public interface IUsersData
    {
        List<Users> Users();
        List<Users> GetUsers(int id);
    }
}
