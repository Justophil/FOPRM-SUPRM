using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOPRM
{
    public partial class FindForm : Form
    {
        MainForm main;
        Data data;

        public FindForm(MainForm main, Data data)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.main = main;
            this.data = data;
            genIp.SelectedIndex = 0;
        }

        private void findB_Click(object sender, EventArgs e)
        {
            List<Patient> res = new List<Patient>();
            
            foreach (Patient p in this.data.Patients)
            {
                if (idIp == null || idIp.Text.Length < 1) ;
                else
                {
                    if (p.PatientId.Equals(idIp.Text)) {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else 
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (fnameIp == null || fnameIp.Text.Length < 1) ;
                else
                {
                    if (p.Fname.Equals(fnameIp.Text)) {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (lnameIp == null || lnameIp.Text.Length < 1) ;
                else
                {
                    if (p.Lname.Equals(lnameIp.Text))
                    {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (insurIp.Text == null || insurIp.Text.Length < 1) ;
                else
                {
                    if (p.MedInsurance.Equals(insurIp.Text)) {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (passportIp == null || passportIp.Text.Length < 1) ;
                else
                {
                    if (p.Passport.Equals(passportIp.Text))
                    {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (ageIp.Value < 1) ;
                else
                {
                    if (p.Age == ageIp.Value)
                    {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (genIp == null || genIp.SelectedItem.ToString().Length < 1) ;
                else
                {
                    if (p.Gender.Equals(genIp.SelectedItem.ToString()))
                    {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                foreach (Patient p1 in res) MessageBox.Show(p1.PatientId);
                if (conIp.Value < 1) ;
                else
                {
                    if (p.Condition == conIp.Value)
                    {
                        if (!res.Contains(p)) res.Add(p);
                    }
                    else
                    {
                        if (res.Contains(p)) res.Remove(p);
                        continue;
                    }
                }
                if (disIp.Text.Equals("SEPARATE EACH BY LINES (ENTER)") || disIp.Text.Length < 1);
                else
                {
                    if (!res.Contains(p))
                        res.Add(p);
                    foreach (string d in disIp.Lines)
                    {
                        if (!p.Diseases.Contains(d))
                            if (res.Contains(p))
                                res.Remove(p);
                            continue;
                    }
                }
            }
            main.updateList(new Data() { Patients = res });
        }

        private void disIp_Enter(object sender, EventArgs e)
        {
            disIp.ForeColor = Color.Black;
            disIp.Text = "";
        }

        private void idIp_Enter(object sender, EventArgs e)
        {
            idIp.Text = "";
        }

        private void fnameIp_Enter(object sender, EventArgs e)
        {
            fnameIp.Text = "";
        }

        private void lnameIp_Enter(object sender, EventArgs e)
        {
            lnameIp.Text = "";
        }

        private void insurIp_Enter(object sender, EventArgs e)
        {
            insurIp.Text = "";
        }

        private void passportIp_Enter(object sender, EventArgs e)
        {
            passportIp.Text = "";
        }
    }
}
