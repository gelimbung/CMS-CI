using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductSvr.MyException
{
    class OutOfStock:ApplicationException
    {
      
        public OutOfStock(string message)
            : base(message)
        {
        }

        
    }
}
