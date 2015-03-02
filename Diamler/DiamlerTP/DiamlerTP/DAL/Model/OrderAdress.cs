using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiamlerTP.DAL.Model
{
    public class OrderAdress
    {
        public int Id { get; set; }
        public int LoadAdress { get; set; }
        public int ContactPerson1 { get; set; }
        public int ContactPerson2 { get; set; }
        public DateTime DateTime { get; set; }
        public string Type { get; set; }
        public bool IsLoad { get; set; }
        public string ContactPerson1Name { get; set; }
        public string ContactPerson2Name { get; set; }
        public string Address { get; set; }
    }
}