using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class Symptom
    {
        public int SymptomId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<SymptomMedicine> SymptomMedicines { get; set; }
    }
}