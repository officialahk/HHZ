using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class ParameterValues
    {
        public int ParameterValuesId { get; set; }

        public int Value { get; set; }

        public int ParameterId { get; set; }



        public virtual Parameter Parameter { get; set; }
    }
}