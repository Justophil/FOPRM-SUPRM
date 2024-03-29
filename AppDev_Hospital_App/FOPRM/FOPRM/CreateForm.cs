﻿using System;
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
    public partial class CreateForm : Form
    {
        MainForm mainForm;
        Data data;
        private static int nextId = Data.readFile().Patients.Count > 0 ? Int32.Parse(Data.readFile().Patients[Data.readFile().Patients.Count - 1].PatientId) + 1 : 1;

        public CreateForm(MainForm Form, Data data)
        {
            InitializeComponent();
            MaximizeBox = false;
            mainForm = Form;
            this.data = data;
            genIp.SelectedIndex = 0;
        }

        private void createB_Click(object sender, EventArgs e)
        {
            if (!validInput()) return;
            data.addPatient(new Patient(String.Format("{0:00000}", nextId++), fnameIp.Text, lnameIp.Text, (int)ageIp.Value, genIp.SelectedItem.ToString(),
                insurIp.Text == null ? "" : insurIp.Text, passportIp.Text == null ? "" : passportIp.Text));
            Data.writeFile(data);
            mainForm.updateList(Data.readFile());
        }
        
        private void clearInput()
        {
            fnameIp.Text = "";
            lnameIp.Text = "";
            insurIp.Text = "";
            passportIp.Text = "";
        }
        private bool validInput()
        {
            if (fnameIp.Text == null || fnameIp.Text.Length == 0) return false;
            if (lnameIp.Text == null || lnameIp.Text.Length == 0) return false;
            if ((int)ageIp.Value < 0) return false;
            if (genIp.SelectedIndex != 0 && genIp.SelectedIndex != 1) return false;
            if ((insurIp.Text == null || insurIp.Text.Length == 0) && (passportIp.Text == null || passportIp.Text.Length == 0)) return false;
            return true;
        }
        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
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
