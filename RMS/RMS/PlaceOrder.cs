using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PlaceOrder
    {
       private Company cmp;
       private Order order;
       public PlaceOrder()
       {
           cmp = new Company();
           order = new Order();
       }
        
        public PlaceOrder(Company cmp, Order order)
        {
            this.cmp = cmp;
            this.order = order;
        }
        
        public Company getCompany()
        {
            return cmp;
        }
        public void setCompnany(Company cmp)
        {
            this.cmp = cmp;
        }
        public Order getOrder()
        {
            return order;
        }
        public void setOrder(Order order)
        {
            this.order = order;
        }
    }
}
