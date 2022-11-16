using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDB
{
    public class Data
    {
        public int ID { get; set; }
        public string Patient_Name { get; set; }
        public string Patient_Surname { get; set; }
        public string Patient_Father_Name { get; set; }
        public string Doctor_Name { get; set; }
        public string Doctor_ID { get; set; }
        public string Patient_Gender { get; set; }
        public string Patient_Disease { get; set; }
        public string Patient_Adress { get; set; }
        public string Patient_Number { get; set; }
        public string Patient_Age { get; set; }


        public Data(int iD, string patient_Name, string patient_Surname, string patient_Father_Name, string doctor_Name, string doctor_ID, string patient_Gender, string patient_Disease, string patient_Adress, string patient_Number, string patient_Age)
        {
            this.ID = iD;
            this.Patient_Name = patient_Name;
            this.Patient_Surname = patient_Surname;
            this.Patient_Father_Name = patient_Father_Name;
            this.Doctor_Name = doctor_Name;
            this.Doctor_ID = doctor_ID;
            this.Patient_Gender = patient_Gender;
            this.Patient_Disease = patient_Disease;
            this.Patient_Adress = patient_Adress;
            this.Patient_Number = patient_Number;
            this.Patient_Age = patient_Age;
        }
    }
}
