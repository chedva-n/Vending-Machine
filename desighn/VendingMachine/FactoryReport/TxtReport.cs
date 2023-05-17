
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryReport
{
    public class TxtReport : Report
    {
        private string path = "../../../dailyReports.txt";
         //StreamWriter sw=new StreamWriter("../../../dailyReports.txt");

        //static FileStream fs;
        public TxtReport(FileType fileType):base(fileType)
        {
           

            //fs= File.Create("dailyReports.txt");
        }

        public override void write(Product product)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"product: {product.Name} price: {product.Price}");
                }
            }
            else using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"product: {product.Name} price: {product.Price}");
            }

            
        }
    }
}
