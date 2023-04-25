using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code_JuanCarlosRuiz
{
    public class User
    {
        private string Name;// Los he puesto privados, porque entiendo que son los datos sensibles a los que el cliente de los correos hace referencia.
        private string Surname;
        private string Email;
        private string Password;
        private string Telephone;
        private string Address;
        private string DNI;
        private List<Product> Wishlist;
        private List<Product> ShoppingCart;

        public void AddToWishlist(Product product)// Método para que el cliente añada un producto a la lista de deseos, tiene que ser public
        {
            Wishlist.Add(product);
        }

        public void AddToCart(Product product)// Método para que el cliente añada un producto al carrito, tiene que ser public.
        {
            ShoppingCart.Add(product); 
        }

        public void LeaveReview(Product identifier, int rating, string comment) // Método para dejar una reseña de un producto comprado por el usuario, tiene que ser public.
        {
           
        }
    }
}
