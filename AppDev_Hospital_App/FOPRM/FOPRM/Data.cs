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
        public static void writeFile(Data data)
        {
            try
            {
                JArray json = new JArray();
                //MessageBox.Show(data.Patients.Count + "");
                for (int i = 0; i < data.Patients.Count; i++)
                {
                    if (data.Patients[i].Diseases.Count == 0)
                    {
                        //MessageBox.Show(i + "");
                        //MessageBox.Show(data.Patients[i].ToString());
                        json.Add(new JObject(new JProperty("patientId", data.Patients[i].PatientId),
                        new JProperty("fname", data.Patients[i].Fname),
                        new JProperty("lname", data.Patients[i].Lname),
                        new JProperty("age", data.Patients[i].Age),
                        new JProperty("condition", data.Patients[i].Condition),
                        new JProperty("gender", data.Patients[i].Gender),
                        new JProperty("medInsurance", data.Patients[i].MedInsurance),
                        new JProperty("passport", data.Patients[i].Passport),
                        new JProperty("diseases", new List<string>())));
                    }
                    else
                    {
                        json.Add(new JObject(new JProperty("patientId", data.Patients[i].PatientId),
                        new JProperty("fname", data.Patients[i].Fname),
                        new JProperty("lname", data.Patients[i].Lname),
                        new JProperty("age", data.Patients[i].Age),
                        new JProperty("condition", data.Patients[i].Condition),
                        new JProperty("gender", data.Patients[i].Gender),
                        new JProperty("medInsurance", data.Patients[i].MedInsurance),
                        new JProperty("passport", data.Patients[i].Passport),
                        new JProperty("diseases", data.Patients[i].Diseases)));
                    }
                }
                using (JsonTextWriter jw = new JsonTextWriter(new StreamWriter(path)))
                {
                    json.WriteTo(jw);
                }
            }
            catch (IOException) { }
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
