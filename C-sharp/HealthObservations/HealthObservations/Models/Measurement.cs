using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthObservations.Models
{
    public class Measurement
    {
        public virtual int Id { get; set; }
        public virtual DateTime ObservationTime { get; set; }
        public virtual int Observation { get; set; }
        public virtual string Notes { get; set; }
        public virtual bool Validated { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string PatientName { get; set; }
    }
}