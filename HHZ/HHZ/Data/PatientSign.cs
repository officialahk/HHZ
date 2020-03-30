using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class PatientSign
    {
        public int PatientSignId { get; set; }

        
        public string SignName { get; set; }

       

        public string SignsValueName { get; set; }

       

       
    }
}