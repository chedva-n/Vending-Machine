using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FactoryReport
{
    public  class ReportFactory
    {
        public Report Create(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.txt:
                    return new TxtReport(fileType);
            }
            return null;
        }

    }
}
