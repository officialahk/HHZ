using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class SymptomMedicine
    {
        public int SymptomMedicineId { get; set; }

        public string Name { get; set; }
        public int Grade { get; set; }
        public string Form { get; set; }
        public string Formula { get; set; }

        public int SymptomId { get; set; }

        public virtual ICollection<Symptom> Symptom { get; set; }


    }
}