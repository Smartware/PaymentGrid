using PaymentGateway.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var billsProvider = new QuickTellerBillProvider();
            var bills = billsProvider.GetBillers();
            var categories = billsProvider.GetBillCategories();

            var joinResult = from b in bills
                             join c in categories
                             on b.CategoryId equals c.CategoryId
                             select new
                             {
                                 BillerName = b.BillerName,
                                 CategoryName = c.CategoryName
                             };



            //Enumerable.Join<>(bills, categories, (b) => b.CategoryId, c => c.CategoryId, (b, c)=> { });
            foreach (var item in joinResult)
            {
                Console.WriteLine($"Name:{item.BillerName}, Category: {item.CategoryName}");
            }
            Console.Read();
        }
    }
}
