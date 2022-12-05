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
        Data data;
        Data view;
        public Printer(Data data, Data view)
        {
            this.data = data;
            this.view = view;
            path = @"C:\Users\2152339\Desktop\FOPRM-SUPRM\AppDev_Hospital_App\Documents\";
        }

        public string makeFile()
        {
            return Path.Combine(path, DateTime.Now.ToString().Replace("/", "-").Replace(":", "'") + ".txt");
        }

        public void print()
        {
            path += DateTime.Now + ".txt";

            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
            {
                StreamWriter fw = new StreamWriter(fs);
                fw.WriteLine();
            }
        }

        public void printBoard()
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
            }
        }
    }
}
