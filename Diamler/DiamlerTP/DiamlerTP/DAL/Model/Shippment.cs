using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
    public class Shippment
    {
        public long ID { get; set; }

        public string SearchName { get; set; }

        public string Name1 { get; set; }

        public string Name2 { get; set; }

        public string Street1 { get; set; }

        public string Street2 { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public int ContactPerson { get; set; }

        public string MainTel { get; set; }

        public string MainFax { get; set; }

        public string MainEmail { get; set; }

        public string Location { get; set; }

        public string OpenTransport { get; set; }

        public string CloseTransport { get; set; }

        public string OperationalArea { get; set; }

        public string Remarks { get; set; }

        public string FlightNo { get; set; }

        public string Function { get; set; }
    }
}
