using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamlerTP.DAL
{
   public class EmployeeInfo
    {
        public long ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Tel { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Abberviation { get; set; }

        public int Status { get; set; }

        public int Title { get; set; } 
    }
}
