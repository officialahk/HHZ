using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientFamilyHistory
    {
        public int PatientFamilyHistoryId { get; set; }
        public string Relation { get; set; }
        public byte Count { get; set; }
        public int Alive { get; set; }
        public int Dead { get; set; }
        public byte DeathAge { get; set; }
        public string ReasionOfDeath { get; set; }
        public string SufferingFrom { get; set; }
    }
}