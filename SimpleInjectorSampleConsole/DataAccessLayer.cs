using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorSampleConsole
{
    public class DataAccessLayer : ICart
    {
        public void Addtocart(List<Item> items)
        {
            // 
            Console.WriteLine("added to db");

            foreach (var item in items)
            {
                Console.WriteLine(item.ItemName);
            }

        }
    }
}
