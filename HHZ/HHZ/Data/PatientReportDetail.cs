using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientReportDetail
    {
        public int PatientReportDetailId { get; set; }
        
        public int ParameterName { get; set; }

        public int ParameterValues { get; set; }
    }
}