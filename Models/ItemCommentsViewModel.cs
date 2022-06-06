using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_2nd.Models
{
    public class ItemCommentsViewModel
    {
        //objective: to combine both models and pass to view 

        public ItemsModel Item { get; set; }

        public List<BuyersComment> Buyer { get; set; }
    }
}