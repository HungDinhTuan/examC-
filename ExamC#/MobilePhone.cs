using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    public class MobilePhone : Product
    {
        public MobilePhone(int id, string name, double price, string producer) : base(id, name, price, producer)
        {
        }

        public override double computeTax()
        {
            return Price *  0.1;
        }
    }
}
