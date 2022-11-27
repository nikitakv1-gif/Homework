using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicshop
{
    public interface IStoreItem
    {
       public double Priсe { get; set; }
        public void DiscountPrice(int persent){}
    }
}
