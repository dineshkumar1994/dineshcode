using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allergy.cs
{
    class Severity
    {

        private String nursename;
        private String symptoms;
        private DateTime timeReported;
        private Maximum severity;
        public enum Maximum
        {   low,
            hmedium,
            high,

        }

        //Higher the number, higher the severity

        public Severity(String nursename, String symptoms, DateTime timeReported,Maximum severity)
        {
            this.nursename = nursename;
            this.symptoms = symptoms;
            this.timeReported = timeReported;
            this.severity = severity;
        }

        public void setNursename(String nursename)
        {
            this.nursename = nursename;
        }

        public void setSymptoms(String symptoms)
        {
            this.symptoms = symptoms;
        }

        public void setSeverity(Maximum severity)
        {
            this.severity = severity;
        }

        public void setTimeReported(DateTime timeReported)
        {
            this.timeReported = timeReported;
        }

        public String getNursename()
        {
            return nursename;
        }

        public String getSymptoms()
        {
            return symptoms;
        }

        public Maximum getSeverity()
        {
            return severity;
        }

        public DateTime getTimeReported()
        {
            return timeReported;
        }
    }
}