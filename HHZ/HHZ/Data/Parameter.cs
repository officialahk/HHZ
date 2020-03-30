using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class Parameter
    {
        public int ParameterId { get; set; }

        public string Name { get; set; }

        public int MinValue { get; set; }

        public int NormalValue { get; set; }

        public int MaxValue { get; set; }

        public int TestId { get; set; }


        public virtual ICollection<ParameterValues> ParameterValues { get; set; }

        public virtual Test Test { get; set; }
    }
}