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
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using System.Data.SqlClient;

namespace FOPRM
{
    public class Data
    {
        private List<Patient> patients;
        public Data()
        {
            patients = readFile().Patients;
        }

        public Data(Data data)
        {
            foreach (Patient p in data.patients)
                patients.Add(p);
        }
        public Data(List<Patient> data)
        {
            patients = data;
        }

        public List<Patient> Patients { get { return patients; } set { patients = value; } }
        // This shit aint working
        public Data readFile()
        {
            Data res = null;
            try
            {
                // When app run the message box is displayed in a loop
                string rawData;
                string path = Path.GetFullPath(@"..\..\..\PatientRecordsData.json");
                using (StreamReader jr = new StreamReader(path))
                {
                    rawData = jr.ReadToEnd();
                    MessageBox.Show(rawData);
                }
                var resu = JsonConvert.DeserializeObject<Data>(rawData);
                res = (Data)resu;
            }
            catch (IOException) { }
            return new Data(new List<Patient>());
        }
        // this shit aint working
        public void writeFile()
        {
            try
            {
                string path = Path.GetFullPath(@"..\..\..\PatientRecordsData.json");

                using (JsonTextWriter jw = new JsonTextWriter(new StreamWriter(path)))
                {
                    
                }
                //jw.
            }
            catch (IOException e) { }
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
