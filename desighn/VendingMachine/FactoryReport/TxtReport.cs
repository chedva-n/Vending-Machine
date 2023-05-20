
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryReport
{
    public class TxtReport : Report
    {
        private string filePath;

        public TxtReport(FileType fileType) : base(fileType)
        {
            string folderPath = "../../../Reports";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string fileName = DateTime.Now.ToString("ddMMyyyy") + ".txt";
            filePath = Path.Combine(folderPath, fileName);
        }

        public override void write(ReportData reportData)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"Product: {reportData.Name} - Price: {reportData.Price}");
                sw.WriteLine();
            }
        }
    }


}

