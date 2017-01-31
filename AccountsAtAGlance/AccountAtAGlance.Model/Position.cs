using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAtAGlance.Model
{
    public class Position
    {
        //Primitive properties
        public int Id { get; set; }
        public int SecurityId { get; set; }
        public decimal Shares { get; set; }
        public decimal Total { get; set; }
        public int BrokerageAccountId { get; set; }

        //Navigation properties
        //virtual modifier: The virtual modifier tells the compiler that when any class derived from class A is used, an override method should be called.
        public virtual Security Security { get; set; }
    }
}
