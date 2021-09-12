using System;
using System.ComponentModel.DataAnnotations;

namespace HTTPApi.Model
{
    public class PaymentListModel
    {
        [Key]
        public int id { get; set; }
        public string date { get; set; }
        public string amount { get; set; }
        public string status { get; set; }
        public int userid { get; set; }
    }
}
