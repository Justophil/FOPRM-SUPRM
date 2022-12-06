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
        private static string path = Path.GetFullPath(@"..\..\..\PatientRecordsData.json");
        public Data()
        {
            patients = readFile().Patients;
            //patients = new List<Patient>();
        }

        public Data(List<Patient> data)
        {
            patients = data;
        }

        public List<Patient> Patients { get { return patients; } set { patients = value; } }
        // This shit aint working
        public static Data readFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();
                    List<Patient> items = JsonConvert.DeserializeObject<List<Patient>>(json);
                    return items != null ? new Data(items) : new Data(new List<Patient>());
                }
            }
            catch (IOException) { }

            return new Data(new List<Patient>());
        }
        // this shit aint working
        public static void writeFile(Data data)
        {
            try
            {
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
