using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using System.Web.Mvc;

namespace BCHHC.Models
{
    public class Patient
    {
        public virtual int Id { get; set; }
        public virtual string Lastname {get;set;}
        public virtual string Firstname { get; set; }
        public virtual ICollection<Measurement> Observations { get; set; }

    }
}
