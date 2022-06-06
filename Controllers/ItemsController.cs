using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_2nd.Models;

namespace Mvc_2nd.Controllers
{
    public class ItemsController : Controller
    {
        // GET: Items
        public ActionResult Index()
        {
            return View();
        }

        public ItemsModel Details()
        {
            ItemsModel im = new ItemsModel()
            {
                ItemId = 1,
                Name = "Dell",
                Category = "Laptop",
                Price = 50000
            };
            return im;
        }

        public List<BuyersComment> GetLists()
        {
            List<BuyersComment> list = new List<BuyersComment>();
            list.Add(new BuyersComment()
            { BuyerId = 1, Name = "Pralhad", Rating = 2, Comments = "It gets hang and heating issue", Date = DateTime.Now }
            );
            list.Add(new BuyersComment()
            { BuyerId = 2, Name = "Pratik", Rating = 3, Comments = "It gets hang and heating issue", Date = DateTime.Now }
            );
            list.Add(new BuyersComment()
            { BuyerId = 3, Name = "Tejas", Rating = 4, Comments = "It gets hang and heating issue", Date = DateTime.Now }
            );
            list.Add(new BuyersComment()
            { BuyerId = 4, Name = "Sushant", Rating = 5, Comments = "It gets hang and heating issue", Date = DateTime.Now }
            );
            list.Add(new BuyersComment()
            { BuyerId = 5, Name = "Saurabh", Rating = 1, Comments = "It gets hang and heating issue", Date = DateTime.Now }
            );

            return list;
        }

        public ActionResult ItemCommentDisplay()
        {
            ItemCommentsViewModel icvm = new ItemCommentsViewModel();
            icvm.Item = Details();
            icvm.Buyer = GetLists();
            return View(icvm);
        }

        
    }
}