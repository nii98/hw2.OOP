using System;
using System.Collections.Generic;
using System.Text;

namespace bookshop2
{


    class EbookFree
    {
        public Order Order;

        public EbookFree(Order order)
        {
            this.Order = order;


        
        }

        public decimal SetRule()
        {
            foreach (Book book in this.Order.basket)
            {
                Book setbook = book;
                foreach (Book p in this.Order.basket)
                {
                    if {setbook.Autor }
                
                }
                

                if (book.Autor == repitAutor && book.Type == TypeOfBook.ebook)
                {
                    Order.totalSum = -book.Cost; 
                
                }
            
            
            
            }
        
        
        
        
        
        }




    }
}
