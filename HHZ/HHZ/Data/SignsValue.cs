using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HHZ.Data
{
    public class SignsValue
    {

        public int SignsValueId { get; set; }

        public string ValueName { get; set; }

        public int SignId { get; set; }


        public virtual Sign Sign { get; set; }




    }
}