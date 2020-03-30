using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class ClinicTime
    {
        public int ClinicTimeId { get; set; }

        public string Day { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool Status { get; set; }

        public int ClinicInfoId { get; set; }   //Foreign Key
    }
}