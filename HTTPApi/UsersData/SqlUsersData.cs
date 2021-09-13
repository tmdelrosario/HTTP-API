using HTTPApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPApi.UsersData
{
    public class SqlUsersData : IUsersData
    {
        private AppDBContext _appDbContext;
        public SqlUsersData(AppDBContext appContext)
        {
            _appDbContext = appContext;
        }
        public List<UsersModel> GetUsers(int id)
        {
            List<PaymentListModel> newPModel = new List<PaymentListModel>();
            List<UsersModel> newUsersData = null;
            foreach (var items in _appDbContext.tblPayment)
            {
                if (id == items.userid)
                {
                    newPModel.Add(items);
                }
            }

            
            if (_appDbContext.tblUser.Find(id) != null)
            {
                newUsersData = new List<UsersModel>()
                {
                    new UsersModel(){
                        id = _appDbContext.tblUser.SingleOrDefault(x =>x.id == id).id,
                        accountBalance = _appDbContext.tblUser.SingleOrDefault(x =>x.id == id).accountBalance,
                        paymentList = newPModel.OrderByDescending(o => o.date).ToList()
                    }
                };
            }

            return newUsersData;
        }

        public List<UsersModel> Users()
        {
            List<UsersModel> newUser = _appDbContext.tblUser.ToList();
            List<UsersModel> newUserData = new List<UsersModel>();

            foreach (var users in newUser)
            {
                List<PaymentListModel> newPModel = new List<PaymentListModel>();
                foreach (var items in _appDbContext.tblPayment)
                {
                    if (users.id == items.userid)
                    {
                        newPModel.Add(items);
                    }
                }

                List<UsersModel> tempUsers = new List<UsersModel>()
                {
                    new UsersModel(){
                        id = _appDbContext.tblUser.SingleOrDefault(x =>x.id == users.id).id,
                        accountBalance = _appDbContext.tblUser.SingleOrDefault(x =>x.id == users.id).accountBalance,
                        paymentList = newPModel.OrderByDescending(o => o.date).ToList()
                    }
                };
                newUserData.AddRange(tempUsers);
            }
            return newUserData;
        }
    }
}
