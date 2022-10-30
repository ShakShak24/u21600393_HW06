using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21600393_HW06.Models
{
    public class Orders
    {
        public product ProductDetails { get; set; }
        public order OrderDetails { get; set; }
        public order_items orderItemsDetails { get; set; }
    }
}