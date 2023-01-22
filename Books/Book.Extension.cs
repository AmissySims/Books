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
                if (CurrentDiscount > 15)
                    return "#7fff00";
                else
                    return "#ffffff";
            }
        }
    }
}
