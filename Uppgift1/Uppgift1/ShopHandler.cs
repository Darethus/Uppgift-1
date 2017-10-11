using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ShopHandler
    {

        private ItemInventory inventory;

        //constructor
        public ShopHandler()
        {
            inventory = new ItemInventory();
        }

        //Add methods to: 

        //return items sorted by price/name/price and name/price grouped by category
        //Also to search based on name, price or both at the same time.
        //Use LINQ to query/filter/order/group the items.

        public IEnumerable<Item> GetAllItems()
        {
            return inventory.GetAllItems();
        }

        static void SearchList()
        {
            //Console.WriteLine("Item List:" + itemList.Capacity);
            Console.WriteLine("Search ");



        }

        static void SortListPrice(IEnumerable<Item> items)
        {
            IEnumerable<Item> myQuery =
                from i in items
                orderby i.Price
                select i;

            Console.WriteLine("Sorting");
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }




        }

        static void SortListName(IEnumerable<Item> items)
        {
            IEnumerable<Item> myQuery =
                from i in items
                orderby i.Name
                select i;

            Console.WriteLine("Sorting");
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }




        }

        static void SortListPriceName(IEnumerable<Item> items)
        {
            IEnumerable<Item> myQuery =
                from i in items
                orderby i.Name
                orderby i.Price
                select i;

            Console.WriteLine("Sorting");
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }




        }

        static void SortListPriceCat(IEnumerable<Item> items)
        {
            IEnumerable<Item> myQuery =
                from i in items
                orderby i.Price
                orderby i.Cat
                select i;

            Console.WriteLine("Sorting");
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }




        }


        static void SearchListName(IEnumerable<Item> items, string search)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Name.Contains(search));
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }
        }


    }
}
