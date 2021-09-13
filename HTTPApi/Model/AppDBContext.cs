using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPApi.Model
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        public DbSet<UsersModel> tblUser { get; set; }
        public DbSet<PaymentListModel> tblPayment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersModel>().HasData(
                new UsersModel
                {
                    id = 1,
                    accountBalance = "30000.00"
                },
                new UsersModel
                {
                    id = 2,
                    accountBalance = "50000.00"
                }
            );

            modelBuilder.Entity<PaymentListModel>().HasData(
                new PaymentListModel
                {
                    id = 1,
                    date = "9/1/2021",
                    amount = "1500.00",
                    status = "OK",
                    userid = 1
                },
                new PaymentListModel
                {
                    id = 2,
                    date = "9/2/2021",
                    amount = "2500.00",
                    status = "OK",
                    userid = 1
                },
                new PaymentListModel
                {
                    id = 3,
                    date = "9/3/2021",
                    amount = "3500.00",
                    status = "OK",
                    userid = 1
                },
                new PaymentListModel
                {
                    id = 4,
                    date = "8/24/2021",
                    amount = "5460.00",
                    status = "CLOSED",
                    userid = 2
                },
                new PaymentListModel
                {
                    id = 5,
                    date = "7/1/2021",
                    amount = "600.00",
                    status = "OK",
                    userid = 2
                }
            );
        }
    }
}
