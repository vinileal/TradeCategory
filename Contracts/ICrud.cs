using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TradeCategory.Contracts
{
    public interface ICrud<T>
    {
        void IsCreate(T entidade);
        void IsUpdate(T entidade);
        IList<T> IsRead();
        void IsDelete(T entidade);
        

    }
}
