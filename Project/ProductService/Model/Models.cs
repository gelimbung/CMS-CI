using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductSvr.Model
{
    public class Room
    {
        public String room_id{get;set;}
        public String room_name { get; set; }
    }

    public class Product {
        public String product_id { get; set; }
        public String uom_code { get; set; }
        public String product_name { get; set; }
        public int qty_stock { get; set; }
        public int product_price { get; set; }
    }

    public class Supplier
    {
        public long supplier_id { get; set; }
        public String supplier_name { get; set; }
        public String address { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
    }

    public class Uom
    {
        public String uom_code { get; set; }
        public String description { get; set; }
    }

    public class Order
    {
        public int order_id { get; set; }
        public int supplier_id { get; set; }
        public String order_date { get; set; }
    }

    public class OrderProduct
    {
        public int order_id{get;set;}
        public String product_id{get;set;}
        public int qty{get;set;}
        public int product_price{get;set;}

    }

    public class Deliver
    {
        public int delivery_id { get; set; }
        public String product_id { get; set; }
        public String room_id { get; set; }
        public String delivery_date { get; set; }
    }

    public class DeliverProduct
    {
        public int delivery_id { get; set; }
        public String product_id { get; set; }
        public int qty { get; set; }
    }
}
