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
    public partial class ViewForm : Form
    {
        MainForm mainForm;
        List<Patient> data;

        bool isViewMode = true;
        Patient pa = null;

        public ViewForm(MainForm main, string ID)
        {
            InitializeComponent();
            MaximizeBox = false;
            
            mainForm = main;
            this.data = Data.readFile().Patients;
            idOp.ReadOnly = true;

            setPatient(ID);
            setMode();

            DisplayProfile();
        }

        public void setPatient(string ID)
        {
            this.pa = null;
            foreach (Patient p in data) {
            if (p.PatientId.Equals(ID))
            {
                pa = p;
                break;
            }
        }
        }

        public void DisplayProfile()
        {
            if (pa == null) return;

            idOp.Text = pa.PatientId;
            ageOp.Text = "" + pa.Age;
            fnameOp.Text = pa.Fname;
            lnameOp.Text = pa.Lname;
            genOp.Text = pa.Gender;
            conOp.Text = "" + pa.Condition;
            insOp.Text = pa.MedInsurance;
            passportOp.Text = pa.Passport;
            disOp.Text = "";
            foreach (string d in pa.Diseases)
                disOp.Text += d + ", ";
        }

        public void setMode()
        {
            if (isViewMode)
            {
                ageOp.Visible = true;
                ageIp.Value = pa.Age;
                ageIp.Visible = false;

                conOp.Visible = true;
                conIp.Visible = false;
                conIp.Value = pa.Condition;

                genOp.Visible = true;
                genIp.Visible = false;
                genIp.SelectedItem = pa.Gender;

                UpdateB.Enabled = false;
                ageOp.ReadOnly = true;
                fnameOp.ReadOnly = true;
                lnameOp.ReadOnly = true;
                genOp.ReadOnly = true;
                conOp.ReadOnly = true;
                insOp.ReadOnly = true;
                passportOp.ReadOnly = true;
                disOp.ReadOnly = true;
            }
            else
            {
                ageOp.Visible = false;
                ageIp.Visible = true;
                conOp.Visible = false;
                conIp.Visible = true;
                genOp.Visible = false;
                genIp.Visible = true;

                UpdateB.Enabled = true;
                ageOp.ReadOnly = false;
                fnameOp.ReadOnly = false;
                lnameOp.ReadOnly = false;
                genOp.ReadOnly = false;
                conOp.ReadOnly = false;
                insOp.ReadOnly = false;
                passportOp.ReadOnly = false;
                disOp.ReadOnly = false;
            }
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (pa == null) return;

            pa.Fname = fnameOp.Text;
            pa.Age = (int) ageIp.Value;
            pa.Lname = lnameOp.Text;
            pa.Gender = genIp.SelectedItem.ToString();
            pa.Condition = (int)conIp.Value;
            pa.MedInsurance = insOp.Text;
            pa.Passport = passportOp.Text;

            pa.Diseases.Clear();
            foreach (string d in disOp.Lines)
            {
                pa.Diseases.Add(d);
            }

            DisplayProfile();
            Data.writeFile(new Data(data));
            mainForm.updateList(new Data(data));
        }

        private void updateModeB_Click(object sender, EventArgs e)
        {
            if (isViewMode)
            {
                notifLb.Text = "Edit Mode On!";
                updateModeB.Text = "View Mode";
                isViewMode = false;
                setMode();
            }
            else
            {
                notifLb.Text = "";
                updateModeB.Text = "Edit Mode";
                isViewMode = true;
                setMode();
            }
        }
    }
}
