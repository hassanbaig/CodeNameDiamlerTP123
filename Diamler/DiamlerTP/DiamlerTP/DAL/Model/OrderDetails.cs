using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
    public class OrderDetails
    {
        public long ID { get; set; }

        public int OrderID { get; set; }

        public string VehicleType { get; set; }

        public string DesignatedFinasNo { get; set; }

        public string NumberPlate { get; set; }

        public string ChassisNo { get; set; }

        public string Receipt { get; set; }

        public string Length { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string Price { get; set; }

        public string TruckType { get; set; }

        public int TransportWay { get; set; }

        public string ModelYear { get; set; }

        public string Capacity { get; set; }

        public string TruckNumberPlate { get; set; }

        public string Shipping { get; set; }

        public string Carnet { get; set; }
    }
}
