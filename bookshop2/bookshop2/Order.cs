using System;
using System.Collections.Generic;
using System.Text;

namespace bookshop2
{
    class Order
    {
        public List<Book> basket;
        public List<IPromo> codes;
        public decimal totalSum;
        public decimal deliveryCost;
        public decimal sumOfEbook;
        public decimal sumOfPbook;
        public decimal percentSale;
        public Order(List<Book> basket)
        {
            deliveryCost = 200;
            sumOfEbook = 0;
            sumOfPbook = 0;
            codes = new List<IPromo>();
            this.basket = basket;
            totalSum = 0;
            percentSale = 1;


        }

        public void UsePromoCode(IPromo promo) 
            {
            codes.Add(promo);
            }


        public decimal CountCost ()
        {
            foreach (Book book in this.basket)
            {
                if (book.Type == TypeOfBook.ebook)
                {
                    sumOfEbook = sumOfEbook + book.Cost;
                
                }

                if (book.Type == TypeOfBook.paper)
                {
                    sumOfPbook = sumOfPbook + book.Cost;

                }

            }


            totalSum = (totalSum + sumOfEbook + sumOfPbook)*percentSale; //+deliveryCost;

            if (totalSum < 1000 || sumOfPbook !=0)
            {
                totalSum = totalSum + deliveryCost;
            }

            
    

            return totalSum;
        }






    }
}
