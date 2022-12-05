using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;

namespace FOPRM
{
    public class Data
    {
        private List<Patient> patients;
        public Data()
        {
            patients = new List<Patient>();
            readFile();
        }

        public Data(Data data)
        {
            foreach (Patient p in data.patients)
                patients.Add(p);
        }

        public List<Patient> Patients { get { return patients; } set { patients = value; } }
        public Data readFile()
        {
            //JsonTextReader json = new JsonTextFileReader();
            return this;
        }

        public void writeFile()
        {
            //JSON
        }

        public void addPatient(Patient p)
        {
            Patients.Add(p);
        }

        public void removePatient(Patient p)
        {
            Patients.Remove(p);
        }
    }
}
