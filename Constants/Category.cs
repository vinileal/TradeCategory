using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategory
{
    public class Category
    {       
        public virtual string categoryName { get; set; }
        public virtual double minValue { get; set; }
        public virtual string businessSector { get; set; }

    }
}
