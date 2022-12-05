using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FOPRM
{
    internal class Printer
    {
        string path;
        public Printer()
        {
            path = @"C:\Users\2152339\Desktop\FOPRM-SUPRM\AppDev_Hospital_App\Documents";
        }

        public string makeFile()
        {
            string s = DateTime.Now.ToString();
            string[] times = new string[] { "h", "m" };
            for (int i = 0; i < 2; i++)
            {
                s = s.Substring(0, s.IndexOf("/")) + "_" + s.Substring(s.IndexOf("/") + 1);
                s = s.Substring(0, s.IndexOf(":")) + times[i] + s.Substring(s.IndexOf(":") + 1);
            }
            return Path.Combine(path, s + ".txt");
        }

        public void print(Patient[] ps)
        {
            path += DateTime.Now + ".txt";

            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
            {
                StreamWriter fw = new StreamWriter(fs);
                fw.WriteLine();
            }
        }

        public void printBoard(Data view)
        {
            using (FileStream fs = File.Open(makeFile(), FileMode.OpenOrCreate))
            {
                StreamWriter fw = new StreamWriter(fs);
                foreach (Patient p in view.Patients)
                {
                    fw.WriteLine("ID: " + p.PatientId);
                    fw.WriteLine("Codition: " + p.Condition);
                    fw.WriteLine("First Name: " + p.Fname);
                    fw.WriteLine("Last Name: " + p.Lname);
                    fw.WriteLine("Age: " + p.Age);
                    fw.WriteLine("Gender: " + p.Gender);
                    fw.WriteLine("Medical Insurance: " + p.MedInsurance);
                    fw.WriteLine("Passport: " + p.Passport);
                    fw.Write("Diseases: ");
                    foreach (string d in p.Diseases)
                        fw.WriteLine("\t" + d);
                    fw.WriteLine("\n");
                }
                fs.Close();
            }
        }
    }
}
