using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HTTPApi.Model
{
    public class UsersModel
    {
        [Key]
        public int id { get; set; }
        public string accountBalance { get; set; }
        public List<PaymentListModel> paymentList { get; set; }
    }
}
