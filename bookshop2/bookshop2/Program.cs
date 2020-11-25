using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start TEST");

            

            Book book1 = new Book("book1", TypeOfBook.paper, "autor1", 100);
            Book book2 = new Book("book2", TypeOfBook.paper, "autor2", 100);
            
            List<Book> Basket = new List<Book>();

            PercentSale percentSale = new PercentSale("%", 10);
            FreeDelivery freeDelivery = new FreeDelivery("freeDel");
            BookAsGift bookAsGift = new BookAsGift("bookAsGift",book2);
            MoneySale moneySale = new MoneySale("SsSS", 50);
            Basket.Add(book2);
          

            Order order1 = new Order(Basket);


            //bookAsGift.UsePromoCode(order1);
            //freeDelivery.UsePromoCode(order1);
            //moneySale.UsePromoCode(order1);
            //percentSale.UsePromoCode(order1); 
            Console.WriteLine(order1.CountCost());

           
        }
    }
}
