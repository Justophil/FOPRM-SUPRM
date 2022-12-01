using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FOPRM
{
    internal class Data
    {
        private static ArrayList patients = null;

        public Data()
        {
            patients = new ArrayList();
        }

        public ArrayList Patients { get; set; }

        /*
         * @param p1 index of first patient
         * @paran p2 index of second patient
         * 
         * Rearrange the array after merged (remove the extra)
        */
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

        public void addPatient(Patient p)
        {
            Patients.Add(p);
        }

        public void removePatient(int p)
        {
            Patients.RemoveAt(p);
        }
    }
}
