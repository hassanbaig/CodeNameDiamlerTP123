using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
    public class Order
    {

        public Order()
        {
            EntryDate = DateTime.Now;
            Tender = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime EntryDate { get; set; }
        public int EmployeeInfo { get; set; }
        public int ShippingMethod { get; set; }
        public string MainReceipt { get; set; } 
        public string AdditionalInformatio { get; set; }
        public int Status { get; set; }
        public int Client { get; set; }
        public string SpecialInstruction { get; set; }
        public int Shippment { get; set; }
        public string DestinationPrice { get; set; }
        public string ReturnPrice { get; set; }
        public int ShippmentContactPerson { get; set; }
        public string VechicleNo { get; set; }
        public string InternalInfo { get; set; }
        public string Insurance { get; set; }
        public string Carnet { get; set; }
        public string ReceiptInfo { get; set; }
        public DateTime Tender { get; set; }
        public string EmployeeInfoName { get; set; }
        public string ShippingMethodName { get; set; }
        public string StatusName { get; set; }
        public string ClientName { get; set; }
        public string ShipmentContactPersonName { get; set; }
        public string AdditionalInformationName { get; set; }
    }
}
