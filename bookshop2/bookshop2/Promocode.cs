using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bookshop2
{
    interface IPromo
    { 
     string PromoCode { get; set; }
        decimal UsePromoCode(Order order);
    
    }

    class FreeDelivery :IPromo
    {
        public string PromoCode { get; set; }

        public FreeDelivery(string code)
        {
            this.PromoCode = code;
        }

        public decimal UsePromoCode(Order order)
        {
            if (order.deliveryCost != 0)
            {

                order.deliveryCost = 0;

                           
            }

            return order.deliveryCost;

        }



    }


    class BookAsGift : IPromo
    {
        public string PromoCode { get; set; }
        private Book book;
        public BookAsGift(string code, Book book = null)
        {
            this.PromoCode = code;
            this.book = book;


        }


        public decimal UsePromoCode(Order order)
        {

            if (book.Type == TypeOfBook.ebook)
            {
                order.sumOfEbook = order.sumOfEbook - book.Cost;
                return order.sumOfEbook;
            }


            if (book.Type == TypeOfBook.paper)
            {
                order.sumOfPbook = order.sumOfPbook - book.Cost;
                return order.sumOfPbook;
            }

            else
            {
                return 0;
            }
        }





    }


    class MoneySale : IPromo
    {

        public string PromoCode { get; set; }
        decimal Sale;
        public MoneySale(string code,  decimal sale)

        {
            this.Sale = sale;
            this.PromoCode = code;
        }

        public decimal UsePromoCode(Order order) 
        
        {
            order.totalSum -= Sale;

            return order.totalSum;
        }
    }



    class PercentSale
    {
        public string PromoCode { get; set; }
        decimal Percent;
        public PercentSale(string code, decimal percent)

        {
            this.Percent = percent;
            this.PromoCode = code;
        }

        public decimal UsePromoCode(Order order)

        {
            order.percentSale =1-( Percent/100);

            return order.percentSale;
        }


    }
}
