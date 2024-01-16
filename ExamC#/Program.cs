using ExamC_;

public class Program
{
    private static void Main(string[] args)
    {
        ComputeTax computeTax = new ComputeTax();   
        List<Product> products = new List<Product>();
        Book book1 = new Book(1, "A", 100000, "ABC");
        Book book2 = new Book(2, "B", 150000, "ABC");
        Book book3 = new Book(3, "C", 200000, "ABC");
        MobilePhone phone1 = new MobilePhone(4, "D", 10000000, "DEF");
        MobilePhone phone2 = new MobilePhone(5, "D", 15000000, "DEF");
        MobilePhone phone3 = new MobilePhone(6, "D", 20000000, "DEF");
        products.Add(book1);
        products.Add(book2);
        products.Add(book3);
        products.Add(phone1);
        products.Add(phone2);
        products.Add(phone3);

        Console.WriteLine("Total tax of the products : " +computeTax.computeTaxTotal(products));
    }
}