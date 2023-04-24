using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public class Order
    {
        public int OrderNumber;
        public DateTime OrderDate;
        public List<Product> Products;
        public List<int> Quantities;
        public float TotalPrice;
    }

}
