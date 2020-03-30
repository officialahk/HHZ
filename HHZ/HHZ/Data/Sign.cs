using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class Sign
    {
        public int SignId { get; set; }


        public string Name { get; set; }


        public virtual ICollection<SignsValue> SignsValues { get; set; }
    }
}