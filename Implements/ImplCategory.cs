using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCategory.Implements
{
    public  class ImplCategory:CrudBase<Category>//class for the future crud
    {
        #region Insert Default Categories
        public  List<Category> DefaultCategories()
        {
            Category category;
            List<Category> categoryList = new List<Category>();

            category = new Category();
            category.categoryName = "HIGH RISK";
            category.minValue = 1000000.00;
            category.businessSector = "PRIVATE";
            categoryList.Add(category);

            category = new Category();
            category.categoryName = "MEDIUM RISK";
            category.minValue = 1000000.00;
            category.businessSector = "PUBLIC";
            categoryList.Add(category);           

            return categoryList;
        }
        #endregion
    }
}
