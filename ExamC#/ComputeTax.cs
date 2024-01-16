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
            double totalBookTax = 0;
            double totalPhonetax = 0;

            foreach (var product in products)
            {
                if (product is Book book)
                {
                    totalBookTax += book.computeTax();
                }

                if (product is MobilePhone phone)
                {
                    totalPhonetax += phone.computeTax();
                }
            }

            Console.WriteLine("Total tax of the books : " + totalBookTax);
            Console.WriteLine("Total tax of the phones : " + totalPhonetax);

            return totalBookTax + totalPhonetax;
        }
    }
}
