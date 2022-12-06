using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOPRM
{
    public class Patient
    {
        private string patientId;
        private string fname;
        private string lname;
        private string medInsurance;
        private string passport;
        private int age;
        private string gender;
        private int condition;
        private List<string> diseases;

        public Patient(string patientID, string fname, string lname, int age, string gender, string medInsuracne, string passport)
        {
            this.patientId = patientID;
            Fname = fname;
            Lname = lname;
            Age = age;
            Gender = gender;
            MedInsurance = medInsuracne;
            Passport = passport;

            diseases = new List<string>();
            condition = 0;
        }

        public string PatientId { get { return this.patientId; } }
        public string Fname { get { return this.fname; } set { this.fname = value; } }
        public string Lname { get { return this.lname; } set { this.lname = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Gender { get { return this.gender; } set { this.gender = value; } }
        public int Condition { get { return this.condition; } set { this.condition = value; } }
        public string MedInsurance { get { return this.medInsurance; } set { this.medInsurance = value; } }
        public string Passport { get { return this.passport; } set { this.passport= value; } }
        public List<string> Diseases { get { return this.diseases; } set { this.diseases = value; } }
    }
}
