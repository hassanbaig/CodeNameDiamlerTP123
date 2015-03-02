using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
    public class ShippmentContactPerson
    {
        public long ID { get; set; }

        public int Shippment { get; set; }

        public int Title { get; set; }

        public string LastNameSp { get; set; }

        public string FirstNameSp { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Function { get; set; }
    }
}
