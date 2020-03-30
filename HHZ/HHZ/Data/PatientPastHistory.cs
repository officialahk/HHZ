using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientPastHistory
    {
        public int PatientPastHistoryId { get; set; }

        public string Disease { get; set; }
        public byte Age { get; set; }
        public byte Duration { get; set; }
        public string  InTermOf { get; set; }
        public string Medication { get; set; }
    }
}