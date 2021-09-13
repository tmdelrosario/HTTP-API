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
        public List<Users> GetUsers(int id)
        {
            List<PaymentList> newPModel = new List<PaymentList>();
            List<Users> newUsersData = null;

            if (_appDbContext.tblUser.Find(id) != null)
            {
                foreach (var items in _appDbContext.tblPayment)
                {
                    if (id == items.userid)
                    {
                        newPModel.Add(new PaymentList
                        {
                            date = items.date,
                            amount = items.amount,
                            status = items.status
                        });
                    }
                }
            
                newUsersData = new List<Users>()
                {
                    new Users(){
                        accountBalance = _appDbContext.tblUser.SingleOrDefault(x =>x.id == id).accountBalance,
                        paymentList = newPModel.OrderByDescending(o => o.date).ToList()
                    }
                };
            }

            return newUsersData;
        }

        public List<Users> Users()
        {
            List<UsersModel> newUser = _appDbContext.tblUser.ToList();
            List<Users> newUserData = new List<Users>();

            foreach (var users in newUser)
            {
                List<PaymentList> newPModel = new List<PaymentList>();
                foreach (var items in _appDbContext.tblPayment)
                {
                    if (users.id == items.userid)
                    {
                        newPModel.Add(new PaymentList
                        {
                            date = items.date,
                            amount = items.amount,
                            status = items.status
                        });
                    }
                }

                List<Users> tempUsers = new List<Users>()
                {
                    new Users(){
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
