using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
   public class ShippmentStatistics
    {
        public long ID { get; set; }

        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }

        public string SumFromID_Order { get; set; }

        public string PriceSum { get; set; }

        public string Receipt { get; set; }

        public string TotalVehicleNo { get; set; }

        public int ShippingMethod { get; set; }

        public string Vehicle { get; set; }
    }
}
