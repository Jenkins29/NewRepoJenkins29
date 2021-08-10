using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product LogitechMouse = new Product("Logitech mouse", 70.00, 14);
            Product iPhone = new Product("iPhone 5s", 999.99, 3);
            Product Epson = new Product("Epson EB-U05", 440.46, 1);

            LogitechMouse.AddOrRemoveQuantity(-7);
            iPhone.ChangePrice(499.59);
            Epson.AddOrRemoveQuantity(9);

            LogitechMouse.PrintProduct();
            iPhone.PrintProduct();
            Epson.PrintProduct();
        }        
    }
}
