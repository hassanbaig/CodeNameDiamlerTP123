using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
   public  class AirStatistics
    {

        public long ID { get; set; }

        public string Transport { get; set; }

        public string PlantDepartment { get; set; }

        public string Country { get; set; }

        public string MBSNo { get; set; }

        public DateTime FlightDate { get; set; }

        public string Flight { get; set; }

        public string AWB { get; set; }

        public string Shipper { get; set; }

        public string ExportKind { get; set; }

        public string TIBCarnetNo { get; set; }

        public string GoodsKind { get; set; }

        public string ChassisNo { get; set; }

        public DateTime ShippmentFromSifi { get; set; }

        public DateTime Arrival { get; set; }

        public string Destination { get; set; }

        public string ReturnDate { get; set; }

        public int Client { get; set; }

        public string CustomClearence { get; set; }

        public string StorageFolderNo { get; set; }

        public string AdditionInfo { get; set; }
    }
}
