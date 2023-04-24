using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public class ProductReview
    {
        public Product identifier;
        public int Rating;
        public string Comment;
        public DateTime Published;

        public float GetRelevance(Product identifier, int Rating) // Con este método público el cliente puede ver la relevancia de las reseñas
        {
            float relevance = 0;
            return relevance;
        }
    }

    
}
