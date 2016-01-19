using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthObservations.Models
{
    /**
     * Patient data 
     * */
    public class Patient
    {
        public virtual int Id { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual ICollection<Measurement> MeasurementList { get; set; }
        //Convenience - perhaps put in separate ViewModel or decorator object?
        public virtual IEnumerable<DateTime> ObservationTimes()
        {
            var query = from measurement in MeasurementList
                        where measurement.PatientId == Id
                        select measurement.ObservationTime;
            List<DateTime> times = query.ToList();
            return times;
        }
        //Convenience - perhaps put in ViewModel or decorator object?
        public virtual IEnumerable<int> Observations()
        {
            var query = from measurement in MeasurementList
                        where measurement.PatientId == Id
                        select measurement.Observation;
            List<int> times = query.ToList();
            return times;
        }
    }
}