using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class DoctorSpecialization
    {
        public Byte DoctorSpecializationId { get; set; }

        

        [Required]
        public string InstituteName { get; set; }

        //[Required]
        //public DateTime ProcurementYear { get; set; }

        public DataType StartingDate { get; set; }

        public DataType EndingDate { get; set; }

        [Required]
        public string Country { get; set; }



        [Required]
        public int SpecializationId { get; set; }              // Foreign Key

        [Required]
        public int DoctorId { get; set; }                   // Foreign Key


        //public virtual Specialization  Specialization { get; set; }        //  Navigational property

        public virtual Doctor Doctors { get; set; }     //  Navigational property

        public virtual Specialization Specializations { get; set; }
    }
}