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

        //--------------------------
        private static int nextId = 1;
        private string patientId;
        private string fname;
        private string lname;
        private string medInsurance;
        private string passport;
        private int age;
        private string gender;
        private int condition;
        private List<string> diseases;

        public Patient(string fname, string lname, int age, string gender, string medInsuracne, string passport)
        {
            patientId = String.Format("{0:00000}", nextId++);
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

        /*
         * Merge 2 profiles
         * 
         * @param p1 first profile
         * @param p2 second profile
         * 
         * p1 becomes p2
         * p1 diseases appends p2 diseases
        */
        public static void merge(Patient p1, Patient p2)
        {
            p1.Fname = p2.Fname;
            p1.Lname = p2.Lname;
            p1.Age = p2.Age;
            p1.Gender = p2.Gender;
            p1.Condition = p2.Condition;

            /*foreach (string e in p2.Diseases)
            {
                p1.Diseases.Append(e);
            }
            */
            p1.Diseases = p2.Diseases;
        }
    }
}
