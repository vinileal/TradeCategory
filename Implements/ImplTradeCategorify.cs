using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCategory.Contracts;
using TradeCategory.Implements;

namespace TradeCategory
{
    public class ImplTradeCategorify : ITrade
    {

        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }


        #region Categorify Trades
        public String TradeCategorify(DateTime reference, ImplTradeCategorify trade)
        {
            ImplCategory category = new ImplCategory();
            List<Category> categoryList = category.DefaultCategories();

            for (int i = 0; i < categoryList.Count; i++)
            {
                if (trade.NextPaymentDate < reference)
                    return "EXPIRED";
                else if (trade.Value > categoryList[i].minValue && trade.ClientSector.ToUpper() == categoryList[i].businessSector.ToUpper())
                    return categoryList[i].categoryName;
            }
            return "UNCATEGORIZED";
        }
        #endregion
    }

}

