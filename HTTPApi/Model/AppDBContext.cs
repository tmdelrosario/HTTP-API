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
    }
}
