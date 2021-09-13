using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPApi.Model
{
    public class Users
    {
        public string accountBalance { get; set; }
        public List<PaymentList> paymentList { get; set; }
    }
}
