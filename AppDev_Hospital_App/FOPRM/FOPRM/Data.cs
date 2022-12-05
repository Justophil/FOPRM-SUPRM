﻿using System;
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
            try
            {
                string path = Path.GetFullPath(@"..\..\..\PatientRecordsData.json");
                if (File.Exists(path)) File.Create(path);
                using (JsonTextReader jr = new JsonTextReader(new StreamReader(path)))
                {
                    while (jr.Read())
                    {
                        if (jr.Value != null)
                        {
                            string[] rawData = jr.Value.ToString().Split(',');
                        }
                    }
                }
            }
            catch (IOException e) {
            }
            return this;
        }

        public void writeFile()
        {
            try
            {
                string path = @"..\..\..\PatientRecordsData.json";
                JsonTextWriter jw = new JsonTextWriter(new StreamWriter(path));
            }
            catch (IOException e)
            {

            }
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
