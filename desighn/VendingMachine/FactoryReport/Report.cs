using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryReport
{
    public abstract class Report
    {

        public FileType fileType { get; set; }

        public Report(FileType fileType)
        {
            this.fileType = fileType;
        }
        public abstract void write(ReportData reportData);
    }
}
