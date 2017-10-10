using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        

        static void SearchList()
        {
            //Console.WriteLine("Item List:" + itemList.Capacity);
            Console.WriteLine("Search ");



        }

        static void SortListPrice(IEnumerable<Item> items)
        {
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }

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
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }

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
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }

            IEnumerable<Item> myQuery =
                from i in items
                orderby i.Price
                orderby i.Name
                select i;

            Console.WriteLine("Sorting");
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }




        }

        static void SortListPriceCat(IEnumerable<Item> items)
        {
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }

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

        static void SortListPrice(IEnumerable<Item> items)
        {
            foreach (Item i in items)
            {
                Console.WriteLine(i.ToString());
            }

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

        static void Main(string[] args)
        {
            //Create a menu and make 
            //calls to ShopHandler for search and sort.

            while (true)
            { 
                Console.WriteLine("Please navigate through the menue by inputting the number \n(1, 2, 3, 4, 5) of your choice"
                    + "\n1. Search"
                    + "\n2. Sort by price"
                    + "\n3. Sort by name"
                    + "\n4. Sort by price and name"
                    + "\n5. Sort by priced and category");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '1':
                        SearchList();
                        break;
                    case '2':
                        SortListPrice(new ShopHandler().GetAllItems());
                        break;
                    case '3':
                        SortListName(new ShopHandler().GetAllItems());
                        break;
                    case '4':
                        SortListPriceName(new ShopHandler().GetAllItems());
                        break;
                    case '5':
                        SortListPriceCat(new ShopHandler().GetAllItems());
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2)");
                        break;
                }
            }


        }
    }

    /*  
    Enumerations are special sets of named values 
    which all maps to a set of numbers, usually integers. 
    They come in handy when you wish to be able to choose 
    between a set of constant values. 
    Category is here used to define category for Items.
   */

    public enum Category
    {
        Food,
        Drinks,
        Bread,
        Books,
        Sport


    }
}
