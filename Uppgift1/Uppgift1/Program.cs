using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        

        //static void SearchList()
        //{
        //    //Console.WriteLine("Item List:" + itemList.Capacity);
        //    Console.WriteLine("Search ");



        //}

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

       
        static void SearchListName(IEnumerable<Item> items, string searchName)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Name.Contains(searchName));
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }
        }


        static void SearchListPriceLower(IEnumerable<Item> items, double searchPrice)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Price <= (searchPrice));
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }
        }



        static void SearchListPriceHigher(IEnumerable<Item> items, double searchPrice)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Price >= (searchPrice));
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }
        }


        static void SearchListPriceName(IEnumerable<Item> items, string searchName, double searchPrice)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Name.Contains(searchName)).Where(i => i.Price == searchPrice);
            foreach (Item i in myQuery)
            {
                Console.WriteLine(i.ToString());
            }
        }



        static void SearchListPriceNameCat(IEnumerable<Item> items, Category searchCat, string searchName, double searchPrice)
        {
            IEnumerable<Item> myQuery = items.Where(i => i.Cat.Equals(searchCat)).Where( i => i.Name.Contains (searchName)).Where(i => i.Price == searchPrice);
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
                Console.WriteLine("Please navigate through the menue by inputting the number \n(1, 2, 3, 4, 5, 6, 7, 8, 9) of your choice"
                    
                    + "\n1. Sort by price"
                    + "\n2. Sort by name"
                    + "\n3. Sort by price and name"
                    + "\n4. Sort by priced and category"
                    + "\n5. Search by name"
                    + "\n6. Search by price lower than"
                    + "\n7. Search by price higher than"
                    + "\n8. Search by price and name"
                    + "\n9. Search by price and name within a category");
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
                Category searchCat = Category.Food;
                string searchName;
                string searchPrice;
                double sp;
                switch (input)
                {
                    
                    case '1':
                        SortListPrice(new ShopHandler().GetAllItems());
                        break;
                    case '2':
                        SortListName(new ShopHandler().GetAllItems());
                        break;
                    case '3':
                        SortListPriceName(new ShopHandler().GetAllItems());
                        break;
                    case '4':
                        SortListPriceCat(new ShopHandler().GetAllItems());
                        break;
                    case '5':
                        Console.WriteLine("Enter search product name:");
                        searchName = Console.ReadLine();
                        SearchListName(new ShopHandler().GetAllItems(), searchName);
                        break;
                    case '6':
                        Console.WriteLine("Enter search price:");
                        string searchPriceLower = Console.ReadLine().Replace('.', ',' );
                        sp = double.Parse(searchPriceLower);
                        SearchListPriceLower(new ShopHandler().GetAllItems(), sp);
                        break;
                    case '7':
                        Console.WriteLine("Enter search price:");
                        string searchPriceHigher = Console.ReadLine().Replace('.', ',');
                        sp = double.Parse(searchPriceHigher);
                        SearchListPriceHigher(new ShopHandler().GetAllItems(), sp);
                        break;
                    case '8':
                        Console.WriteLine("Enter search price:");
                        searchPrice = Console.ReadLine().Replace('.', ',');
                        Console.WriteLine("Enter product name:");
                        searchName = Console.ReadLine();
                        sp = double.Parse(searchPrice);
                        SearchListPriceName(new ShopHandler().GetAllItems(),searchName, sp);
                        break;
                    case '9':
                        Console.Write("Enter category (Food, Drinks, )");
                        string strCat = Console.ReadLine();

                        if (strCat.Equals("Food")) searchCat = Category.Food;

                        Console.WriteLine("Enter search price:");
                        searchPrice = Console.ReadLine().Replace('.', ',');
                        Console.WriteLine("Enter product name:");
                        searchName = Console.ReadLine();
                        sp = double.Parse(searchPrice);
                        SearchListPriceNameCat(new ShopHandler().GetAllItems(), searchCat, searchName, sp);
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6, 7, 8, 9)");
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
