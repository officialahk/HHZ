using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientLabTest
    {
        public int PatientLabTestId { get; set; }

        public string TestName { get; set; }


        [ForeignKey("PatientReportDetails")]
        public int PatientReportDetailId { get; set; }


        public string DoctorRemarks { get; set; }

        public DateTime TestDate { get; set; }

        public string LabName { get; set; }

        
        public virtual ICollection<PatientReportDetail> PatientReportDetails { get; set; }

        
    }
}