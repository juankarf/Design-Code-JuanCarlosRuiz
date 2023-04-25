using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public abstract class Product
    {
        public int Identifier;  // Lo he puesto en público, porque el cliente cuando deje una reseña, utilizará el identificador. Podría también dejarse en privado, si fuera algo interno para la empresa.
        public string Name;
        public string Brand;
        public List<string> Images;// Lo he puesto como string, porque he supuesto que las imágenes tendrán sus propios enlaces.
        public float BasePrice;
        public bool HasDiscount;
        public float Discount;
        public List<Label> Labels; 
        public string Category;
        public string Subcategory;
        public string Subsubcategory;
        private List<ProductReview> ProductReviews; //Entiendo que debe ser privado, ya que el cliente no va a ver el listado completo de reseñas, si nos interesa que lo vea también, será público.

        public abstract string GetCategory();
        public abstract string GetSubcategory();
        public abstract string GetSubsubcategory();

        public float GetFinalPrice()// Será público para que el cliente pueda obtener el precio del producto si es que tiene descuento.
        {
            if (HasDiscount)
            {
                return BasePrice * (1 - Discount / 100);
            }
            else
            {
                return BasePrice;
            }
        }

        public float GetAverageRating() // Será público para que el cliente pueda ver la media de las reseñas.
        {
            if (ProductReviews.Count == 0)
            {
                return 0;
            }
            else
            {
                int totalRating = 0;
                int numReviews = ProductReviews.Count;
                return totalRating / numReviews;
            }
        }

    }
}


