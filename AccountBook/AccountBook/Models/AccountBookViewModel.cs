using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models
{
    public class AccountBookViewModel
    {
        public int RecordSN { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public int Money { get; set; }
    }
}