using HHZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        
        public string ProfessionalStatement { get; set; }

        public string Biography { get; set; }

        
        //public DateTime PracticingFrom { get; set; }
        
        public string ContactNumber  { get; set; }
        
        public string PostalAddress { get; set; }
        
        public int Cnic { get; set; }

        public bool MaritalStatus { get; set; }
  
        public string SpouseName { get; set; }

        public string ImageUrl { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Linkedin { get; set; }

        public string Rss { get; set; }

        public string GooglePlus { get; set; }

        public string Youtube { get; set; }

        public string Website { get; set; }




        

        
        public int DoctorTypeId { get; set; }          // Foreign key


        public string UserId { get; set; }             // Foreign Key





        public virtual DoctorType DoctorType { get; set; }

        public ApplicationUser User { get; set; }

        

        public virtual ICollection<DoctorQualification>  DoctorQualifications   { get; set; }   //  Navigational property
        public virtual ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }   //  Navigational property
        public virtual ICollection<DoctorExperience>     DoctorExperiences { get; set; }   //  Navigational property




    }
}