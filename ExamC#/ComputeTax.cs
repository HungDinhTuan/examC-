using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamC_
{
    public class ComputeTax
    {
        public double computeTaxTotal(List<Product> products)
        {
            double totalTax = 0;

            for (int i = 0; i < products.Count ; i++)
            {
                totalTax += products[i].computeTax();
            }
            return totalTax;
        }
    }
}
