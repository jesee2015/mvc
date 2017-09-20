using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAppDemo.Models
{
    public class Auction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public List<Bid> Bids { get; set; }
    }

    public class Bid
    {
        public DateTime TimeStamp { get; set; }
        public decimal Amount { get; set; }
    }
}