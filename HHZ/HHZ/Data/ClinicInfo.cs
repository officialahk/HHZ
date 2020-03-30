using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class ClinicInfo
    {
        
        public int ClinicInfoId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Contact { get; set; }

        public int DoctorId { get; set; }



        public virtual Doctor Doctor { get; set; }

        public virtual ICollection<ClinicTime> ClinicTimes { get; set; }   //  Navigational property


    }
}