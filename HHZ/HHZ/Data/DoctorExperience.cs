using System.ComponentModel.DataAnnotations;

namespace HHZ.Data
{
    public class DoctorExperience
    {

        public int DoctorExperienceId { get; set; }

        public string Designation { get; set; }

        public DataType StartingDate { get; set; }

        public DataType EndingDate { get; set; }

        public int DoctorId { get; set; }                   // Foreign Key

        public virtual Doctor Doctors { get; set; }     //  Navigational property



    }
}