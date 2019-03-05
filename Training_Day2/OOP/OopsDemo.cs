using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2.OOP
{

    class Items
    {
        public string itemName;
        int itemId;

        public Items()
        {
            Console.WriteLine("Parameterless Constructor");
        }

        public Items(string itemname, int itemid)
        {
            this.itemName = itemname;
            this.itemId = itemid;
        }

        public void GetItem()
        {
            Console.WriteLine("Name= " + itemName + " and " + itemId);
        }
    }
    class OopsDemo
    {
        static void Main(string[] args)
        {
            Items item = new Items();
            Items i = new Items("Demo Item", 101);
            i.GetItem();
            Console.ReadLine();
        }
    }


}
