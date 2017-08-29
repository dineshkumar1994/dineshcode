using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication
{
    class Frequency
    {
        public PartoftheDay _part;
        public enum PartoftheDay
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public Frequency(PartoftheDay part)
        {
            this._part = part;

        }

        public Frequency()
        {
            // TODO: Complete member initialization
        }
        public PartoftheDay getPart()
        {
            return _part;
        }
        public void setPart(PartoftheDay part)
        {
            this._part = part;
        }
        
    }
}