using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.FactoryReport;
namespace VendingMachine
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public void WriteToFile(Product product)
        {
            ReportFactory reportFactory = new ReportFactory();
            Report report = reportFactory.Create(FileType.txt);
            report.write(product);
        }

    }
}
