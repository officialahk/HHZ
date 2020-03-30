using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientSymptom
    {
        public int PatientSymptomId { get; set; }

        public string SymptomName { get; set; }

        public string Intensity { get; set; }

        public byte Duration { get; set; }

        public string InTermOf { get; set; }

    }
}