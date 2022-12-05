using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOPRM
{
    public partial class MergeForm : Form
    {
        MainForm mainForm;
        Data data;
        
        Patient p1;
        Patient p2;

        public MergeForm(MainForm main, Data data)
        {
            InitializeComponent();
            mainForm = main;
            this.data = data;

            

            updateCB();
        }

        private void updateCB()
        {
            p1CB.Items.Clear(); p2CB.Items.Clear();
            foreach (Patient p in data.Patients)
            {
                p1CB.Items.Add(p.PatientId);
                p2CB.Items.Add(p.PatientId);
            }
        }

        private bool isAllOptsSelected()
        {
            if (ageIp.SelectedItem == null ||
                genIp.SelectedItem == null ||
                fnameIp.SelectedItem == null ||
                lnameIp.SelectedItem == null ||
                conIp.SelectedItem == null ||
                insIp.SelectedItem == null ||
                passportIp.SelectedItem == null ||
                disIp.SelectedItem == null) 
                return false;
            mergeB.Enabled = true;
            return true;
        }

        private void p1CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p1CB.SelectedItem == null || p2CB.SelectedItem == null || p2CB.SelectedItem == p1CB.SelectedItem)
            {
                optPanel.Visible = false;
                return;
            }

            setPatients();
            optPanel.Visible = true;
        }

        private void p2CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p1CB.SelectedItem == null || p2CB.SelectedItem == null || p2CB.SelectedItem == p1CB.SelectedItem)
            {
                optPanel.Visible = false;
                return;
            }

            setPatients();
            optPanel.Visible = true;
        }

        public void setPatients()
        {
            p1 = null;
            p2 = null;
            foreach (Patient p in data.Patients)
            {
                if (p.PatientId.Equals(p1CB.SelectedItem))
                    p1 = p;
                if (p.PatientId.Equals(p2CB.SelectedItem))
                    p2 = p;
                if (p1 != null && p2 != null)
                {
                    idOp.Text = p1.PatientId;
                    setOpts();
                    break;
                }
            };
        }

        public void setOpts()
        {
            //clear current options
            ageIp.Items.Clear();
            genIp.Items.Clear();
            fnameIp.Items.Clear();
            lnameIp.Items.Clear();
            conIp.Items.Clear();
            insIp.Items.Clear();
            passportIp.Items.Clear();
            disIp.Items.Clear();

            //insert options
            ageIp.Items.Add(p1.Age);
            ageIp.Items.Add(p2.Age);

            genIp.Items.Add(p1.Gender);
            genIp.Items.Add(p2.Gender);

            fnameIp.Items.Add(p1.Fname);
            fnameIp.Items.Add(p2.Fname);
            
            lnameIp.Items.Add(p1.Lname);
            lnameIp.Items.Add(p2.Lname);

            conIp.Items.Add(p1.Condition);
            conIp.Items.Add(p2.Condition);
            
            insIp.Items.Add(p1.MedInsurance);
            insIp.Items.Add(p2.MedInsurance);

            passportIp.Items.Add(p1.Passport);
            passportIp.Items.Add(p2.Passport);

            disIp.Items.Add("P1 Diseases");
            disIp.Items.Add("P2 Diseases");
            disIp.Items.Add("Combine");
        }

        private void ageIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ageOp.Text = "" + ageIp.SelectedItem;
            if (isAllOptsSelected()) 
                resPanel.Visible = true;
        }

        private void genIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            genOp.Text = "" + genIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void fnameIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnameOp.Text = "" + fnameIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void lnameIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            lnameOp.Text = "" + lnameIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void conIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            conOp.Text = "" + conIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void insIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            insOp.Text = "" + insIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void passportIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            passportOp.Text = "" + passportIp.SelectedItem;
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void disIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            disOp.Text = "";
            if (disIp.SelectedIndex == 2) {
                foreach (String s in p1.Diseases)
                    disOp.Text += s + ", ";
                foreach (String s in p2.Diseases)
                    disOp.Text += s + ", ";
            }
            else if (disIp.SelectedIndex == 1)
            {
                foreach (String s in p1.Diseases)
                    disOp.Text += s + ", ";
            }
            else
            {
                foreach (String s in p2.Diseases)
                    disOp.Text += s + ", ";
            }
            if (isAllOptsSelected())
                resPanel.Visible = true;
        }

        private void mergeB_Click(object sender, EventArgs e)
        {
            p1.Age = int.Parse(ageOp.Text);
            p1.Fname = fnameOp.Text;
            p1.Lname = lnameOp.Text;
            p1.Condition = int.Parse(conOp.Text);
            p1.Gender = genOp.Text;
            p1.MedInsurance = insOp.Text;
            p1.Passport = passportOp.Text;

            p1.Diseases.Clear();
            
            switch (disIp.SelectedItem)
            {
                case "P1 Diseases":
                    fnameTb.Text = "hi";
                    foreach (String s in p1.Diseases)
                        p1.Diseases.Add(s);
                    break;
                case "P2 Diseases":
                    fnameTb.Text = "elo";
                    foreach (String s in p2.Diseases)
                        p1.Diseases.Add(s);
                    break;
                default:
                    fnameTb.Text = "wat";
                    foreach (String s in p1.Diseases)
                        p1.Diseases.Add(s);
                    foreach (String s in p2.Diseases)
                        p1.Diseases.Add(s);
                    break;
            }
            /**
            if (disIp.SelectedIndex == 2)
            {
                foreach (String s in p1.Diseases)
                    p1.Diseases.Add(s);
                foreach (String s in p2.Diseases)
                    p1.Diseases.Add(s);
            }
            else if (disIp.SelectedIndex == 0)
            {
                foreach (String s in p1.Diseases)
                    p1.Diseases.Add(s);
            }
            else
            {
                foreach (String s in p2.Diseases)
                    p1.Diseases.Add(s);
            }
            */

            //foreach (String s in disOp.Text.Replace(", ", ",").Split(','))
            //    p1.Diseases.Add(s);

            for (int i = 0; i < data.Patients.Count; i++)
            {
                if (data.Patients.ElementAt(i).PatientId.Equals(p1.PatientId))
                {
                    data.Patients.ToArray()[i] = p1;
                    break;
                }
            }

            p1CB.SelectedItem = null;
            p2CB.SelectedItem = null;
            resPanel.Visible = false;

            data.removePatient(p2);
            updateCB();
            mainForm.updateList();
        }

        private void lnameOp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
