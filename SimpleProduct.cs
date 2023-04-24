using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public class SimpleProduct : Product
    {
        public string Category;
        public string Subcategory;

        public override string GetCategory() //Con este método público obtendremos la categoría de un producto simple.
        {
            return Category;
        }

        public override string GetSubcategory() //Con este método público obtendremos la subcategoría de un producto simple.
        {
            return Subcategory;
        }

        public override string GetSubsubcategory() //Como los productos simples no tienen implementada subsubcategoría, me aparecía esta declaración de excepción como corrección al desarrollar el código.
        {
            throw new NotImplementedException();
        }
    }
}