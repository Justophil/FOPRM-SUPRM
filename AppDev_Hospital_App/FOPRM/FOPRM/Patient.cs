﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOPRM
{
    internal class Patient
    {
        private static int nextId = 1;
        private string patientId;
        private string fname;
        private string lname;
        private int age;
        private char gender;
        private int condition;
        private string[] diseases;

        /**
         * Create Patient profile with condition and diseases
         * 
         * param @fname First Name
         * param @lname Last Name
         * param @age 1-150
         * param @gender m or f (male/female)
         * param @condition 1-5 (less urgent - more urgent), 6 for dead
         * param @diseases array of strings (diseases)
        */
        public Patient(string fname, string lname, int age, char gender, int condition, string[] diseases)
        {
            PatientId = String.Format("{0;00000}", nextId++);
            Fname = fname;
            Lname = lname;
            Age = age;
            Gender = gender;
            Condition = condition;
            Diseases = diseases;
        }

        /**
         * Create base Patient profile
         * 
         * param @fname First Name
         * param @lname Last Name
         * param @age 1-150
         * param @gender m or f (male/female)
        */
        public Patient(string fname, string lname, int age, char gender)
        {
            Fname = fname;
            Lname = lname;
            Age = age;
            Gender = gender;
        }

        public string PatientId { get { return this.patientId; } set { this.patientId = value; } }
        public string Fname { get { return this.fname; } set { this.fname = value; } }
        public string Lname { get { return this.lname; } set { this.lname = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public char Gender { get { return this.gender; } set { this.gender = value; } }
        public int Condition { get { return this.condition; } set { this.condition = value; } }
        public string[] Diseases { get { return this.diseases; } set { this.diseases = value; } }

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
