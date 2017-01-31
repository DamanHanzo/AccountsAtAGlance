using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Model
{
    public class BrokerageAccount
    {
        public BrokerageAccount()
        {
            //HasSet: A HashSet holds a set of objects, but in a way that it allows you to easily and quickly determine whether an object is already in the set or not.
            //It does so by internally managing an array and storing the object using an index which is calculated from the hashcode of the object.
            Positions = new HashSet<Position>();
            Orders = new HashSet<Order>();
        }

        //Primitive properties
        [Key]
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTitle { get; set; }
        public decimal Total { get; set; }
        public decimal MarginBalance { get; set; }
        public bool IsRetirement { get; set; }
        public int CustomerId { get; set; }
        public decimal CashTotal { get; set; }
        public decimal PositionsTotal { get; set; }

        //Navigation properties
       public ICollection<Position> Positions { get; set; }
       public ICollection<Order> Orders { get; set; }
       public WatchList WatchList { get; set; } 
    }
}
