using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication
{
    class Medicine
    {
        private String name;
        private String disease;
        private String composition;
        private String details;
        //private List<Frequency> frequencyList;



        //public List<Frequency> getFrequencyList()
        //{
        //    return frequencyList;
        //}

        //public void setFrequencyList(List<Frequency> frequencyList)
        //{
        //    this.frequencyList = frequencyList;
        //}

        public String getName()
        {
            return name;
        }

        public Medicine(String name, String composition, String details)
        {
            this.name = name;
            this.setComposition(composition);
            this.setDetails(details);

        }

        public void setName(String name)
        {
            this.name = name;
        }
        public String getDisease()
        {
            return disease;
        }
        public void setDisease(String disease)
        {
            this.disease = disease;
        }

     
        public String getComposition()
        {
            return composition;
        }

     
        public void setComposition(String composition)
        {
            this.composition = composition;
        }

    
        public String getDetails()
        {
            return details;
        }

        public void setDetails(String details)
        {
            this.details = details;
        }
    }
}