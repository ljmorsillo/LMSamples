using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;


namespace BCHHC.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public DateTime ObservationTime { get; set; }
        public string Notes { get; set; }
        public ICollection<int> PatientId { get; set; }

    }
}