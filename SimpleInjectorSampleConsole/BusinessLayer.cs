using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInjectorSampleConsole
{
   public class BusinessLayer
    {
        private ICart _objcart;

       public BusinessLayer(ICart obj)
        {
            this._objcart = obj;
        }

        public void InsertCart(List<Item> list)
        {
            _objcart.Addtocart(list);
        }
       
    }
}
