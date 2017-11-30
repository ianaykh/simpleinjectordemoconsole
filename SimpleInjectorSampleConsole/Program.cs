using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace SimpleInjectorSampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();



            container.Register<ICart, DataAccessLayer>();

            var BL = container.GetInstance<BusinessLayer>();

            List<Item> list = new List<Item>
            {
                new Item { ItemId = 90, ItemName = "sdhfsd" },

                new Item { ItemId = 4354, ItemName = "vbnvbn" }
            };
            BL.InsertCart(list);


        }
    }
}
