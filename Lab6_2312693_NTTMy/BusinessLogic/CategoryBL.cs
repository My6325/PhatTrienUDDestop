using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryBL
    {
        CategoryDA CategoryDA = new CategoryDA();
        public List<Category> GetAll()
        { 
            return CategoryDA.GetAll();
        }
        public int Insert(Category category)
        {
            return CategoryDA.Insert_Update_Delete(category, 0); 
        }
        public int Update(Category category)
        {
            return CategoryDA.Insert_Update_Delete(category, 1);
        }
        public int Delete(Category category)
        {
            return CategoryDA.Insert_Update_Delete(category, 2);
        }
    }
}
