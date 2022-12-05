using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
        public void readFile()
        {
            //JSON
        }

        public void writeFile()
        {
            //JSON
        }

        /*
         * @param p1 index of first patient
         * @paran p2 index of second patient
         * 
         * Rearrange the array after merged (remove the extra)
         * 
        */
        /*
        public void mergePatients(int p1, int p2)
        {
            Patient.merge((Patient)patients[p1], (Patient)patients[p2]);
            removePatient(p2);

            ArrayList temp = new ArrayList();
            foreach (Patient p in patients) {
                if (p != null)
                    temp.Add(p);
            }
            Patients = temp;
        }
        */
        // We already have a merge method in Patient Class
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
