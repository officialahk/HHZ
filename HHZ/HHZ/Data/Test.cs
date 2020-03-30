using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class Test
    {
        public int TestId { get; set; }

        public string Name { get; set; }


        public virtual ICollection<Parameter>  Parameters { get; set; }

    }
}