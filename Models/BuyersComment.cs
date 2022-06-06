using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_2nd.Models
{
    public class BuyersComment
    {
        public int BuyerId { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public string Comments { get; set; }

        public DateTime Date { get; set; }
    }
}