using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
  public  class ContactPerson
    {

        public long ID { get; set; }

        public int Company { get; set; }

        public int Title { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Department { get; set; }

        public string Tel { get; set; }

        public string Mobile { get; set; }

        public string Typ { get; set; }

        public string Industrialplant { get; set; }
    }
}
