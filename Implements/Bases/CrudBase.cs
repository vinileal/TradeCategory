using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TradeCategory.Contracts;

namespace TradeCategory.Implements
{
    public class CrudBase<T> : ICrud<T> where T : class
    {
        public void IsCreate(T entidade)
        {
            throw new NotImplementedException();
        }

        public void IsDelete(T entidade)
        {
            throw new NotImplementedException();
        }

        public IList<T> IsRead()
        {
            throw new NotImplementedException();
        }

        public void IsUpdate(T entidade)
        {
            throw new NotImplementedException();
        }
    }
}
