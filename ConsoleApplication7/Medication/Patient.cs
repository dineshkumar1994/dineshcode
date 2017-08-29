using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication
{


    public class Patient
    {

        private String name;
        private String disease;
       // private List<Medicine> medicineList;



        public Patient(String name, String disease)
        {
            this.setName(name);
            this.setDisease(disease);

        }



        //public List<Medicine> getMedicineList()
        //{
        //    return medicineList;
        //}



        //public void setMedicineList(List<Medicine> medicineList)
        //{
        //    this.medicineList = medicineList;
        //}



        public String getName()
        {
            return name;
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
    }
}
