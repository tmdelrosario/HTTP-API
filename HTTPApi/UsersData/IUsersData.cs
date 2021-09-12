using System;
using System.Collections.Generic;
using HTTPApi.Model;

namespace HTTPApi.UsersData
{
    public interface IUsersData
    {
        List<UsersModel> Users();

        List<UsersModel> GetUsers(int id);
    }
}
