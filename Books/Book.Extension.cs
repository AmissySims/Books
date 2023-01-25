using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public partial class Book
    {
        public string ColorDis
        {
            get
            {
                if (MaxDiscount > 15)
                    return "#7fff00";
                else
                    return "#ffffff";
            }
        }
        public string NowCost
        {
            get
            {
                if (CurrentDiscount > 2)
                    return Convert.ToString(Cost - Cost * CurrentDiscount / 100);
                else
                    return "";
            }
        }
        public string CostText
        {
            get
            {
                if (CurrentDiscount > 2)
                    return "Strikethrough";
                else
                    return "";
            }
        }

    }
}
