using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public class ComplexProduct : Product
    {
        public string Category;
        public string Subcategory;
        public string Subsubcategory;

        public override string GetCategory() //Con este método público obtendremos la categoría de un producto complejo.
        {
            return Category;
        }

        public override string GetSubcategory() //Con este método público obtendremos la subcategoría de un producto complejo.
        {
            return Subcategory;
        }

        public override string GetSubsubcategory()//Con este método público obtendremos la subsubcategoría de un producto complejo.
        {
            return Subsubcategory;
        }
    }
}
