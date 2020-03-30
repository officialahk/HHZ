using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using HHZ.Models;

namespace HHZ.Data
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string RegId { get; set; }

        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public bool MaritalStatus { get; set; }
        public string SpouseName { get; set; }
        public byte Children { get; set; }
        public string Cast { get; set; }
        public DateTime DOB { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string Designation { get; set; }
        public DateTime Sufferingfrom { get; set; }
        public int Cnic { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
        public int ZipCode { get; set; }

        

        
        public string UserId { get; set; }             // Foreign Key

        [ForeignKey("PatientSigns")]
        public  int PatientSignId { get; set; }        // Foreign Key

        [ForeignKey("PatientPqrs")]
        public int PatientPqrsId { get; set; }

        [ForeignKey("PatientFamilyHistories")]
        public int PatientFamilyHistoryId { get; set; }
       
        [ForeignKey("PatientLabTests")]
        public int PatientLabTestId { get; set; }


        [ForeignKey("PatientPastHistories")]
        public int PatientPastHistoryId { get; set; }


        [ForeignKey("PatientSymptoms")]
        public int PatientSymptomId { get; set; }




        public ApplicationUser User { get; set; }


        public virtual  ICollection<PatientSign> PatientSigns { get; set; }
        public virtual ICollection<PatientFamilyHistory> PatientFamilyHistories { get; set; }
        public virtual ICollection<PatientPqrs> PatientPqrs { get; set; }
        public virtual ICollection<PatientLabTest> PatientLabTests { get; set; }
        public virtual ICollection<PatientPastHistory> PatientPastHistories { get; set; }
        public virtual ICollection<PatientSymptom> PatientSymptoms { get; set; }



        

    }
}