using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
             PrintCube();
             PrintOrderbydate();
             OrderBroupBy();
             OrderPricedetails();
             DispalyEvenNum();
             FindMaxQuantity();

            Console.ReadKey();
        }

        public static void PrintCube()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var cubNo = from num in arr
                        let cub = num * num * num
                        where cub > 20 && cub < 1000
                        select new { num, cub };

            foreach (var item in cubNo)
            {
                Console.WriteLine(item);
            }
           

        }

        public static void PrintOrderbydate()
        {
            Order od = FillOrderList();
            var details = from ord in od.OrdersList
                          orderby ord.OrderDate descending 
                          select new { ord.ItemName, ord.OrderDate,ord.Quantity };

            foreach (var item in details)
            {
                Console.WriteLine(item);
            }
        }

        public static void OrderBroupBy()
        {
            Order od = FillOrderList();

             var details = od.OrdersList.GroupBy(x => x.OrderDate.Month).Select(grp =>grp).ToList();
           //// var details = from ord in od.OrdersList
           //               group ord by ord.OrderDate.Month into g
           //               orderby g.Key
           //               select g;

            foreach (var OrderGroup in details)
            {
                foreach (var item in OrderGroup)
                {
                    Console.WriteLine($"\t{item.ItemName}, {item.OrderDate}, {item.Quantity}");
                }
            }
        }

        public static void OrderPricedetails()
        {
            Order od = FillOrderList();
            List<Item> itemlist = FillItemList();

            var details = from de in od.OrdersList
                          join it in itemlist on de.ItemName equals it.ItemName
                          orderby de.OrderDate descending
                          select new { de.ItemName, de.OrderDate, de.Quantity, it.Price, TotalPrice = de.Quantity * it.Price };

            foreach (var item in details)
            {
                Console.WriteLine(item);
            }

        }

        public static void DispalyEvenNum()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var details = from item in arr
                          let res = item % 2
                          where res == 0
                          select new { item };
            foreach (var item in details)
            {
                Console.WriteLine(item);
            }

        }

        public static void FindMaxQuantity()
        {
            Order od = FillOrderList();
            var details = (from ord in od.OrdersList
                           select ord.Quantity).Max();
            Console.WriteLine(details);
        }



        private static Order FillOrderList()
        {
            Order od = new Order();
            od.OrdersList.Add(new Order() { OrderID = 1, ItemName = "Pen", OrderDate = new DateTime(2017, 10, 22), Quantity = 10 });
            od.OrdersList.Add(new Order() { OrderID = 2, ItemName = "Paper", OrderDate = new DateTime(2018, 04, 01), Quantity = 100 });
            od.OrdersList.Add(new Order() { OrderID = 3, ItemName = "Pencil", OrderDate = new DateTime(2018, 03, 11), Quantity = 50 });
            od.OrdersList.Add(new Order() { OrderID = 4, ItemName = "Book", OrderDate = new DateTime(2018, 08, 19), Quantity = 70 });
            od.OrdersList.Add(new Order() { OrderID = 5, ItemName = "Note", OrderDate = new DateTime(2018, 06, 05), Quantity = 500 });
            od.OrdersList.Add(new Order() { OrderID = 6, ItemName = "Sketch", OrderDate = new DateTime(2018, 06, 11), Quantity = 1000 });
            od.OrdersList.Add(new Order() { OrderID = 7, ItemName = "Clib", OrderDate = new DateTime(2018, 08, 05), Quantity = 500 });

            return od;

        }

        private static List<Item> FillItemList()
        {
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item() { ItemName= "Pen", Price=10});
            itemList.Add(new Item() { ItemName = "Paper", Price = 3 });
            itemList.Add(new Item() { ItemName = "Pencil", Price = 5 });
            itemList.Add(new Item() { ItemName = "Book", Price = 100 });
            itemList.Add(new Item() { ItemName = "Note", Price = 60 });
            itemList.Add(new Item() { ItemName = "Sketch", Price = 25 });
            itemList.Add(new Item() { ItemName = "Clib", Price = 10 });

            return itemList;
        }
    }
}
