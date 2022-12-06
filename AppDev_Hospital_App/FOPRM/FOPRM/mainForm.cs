using System;
using System.Collections;
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
    public partial class MainForm : System.Windows.Forms.Form
    {

        Data data;
        Data view;
        private StartForm StartForm;
        bool ascending;
        Printer printer;

        public MainForm(StartForm titleScreen)
        {
            InitializeComponent();
            MaximizeBox = false;
            StartForm = titleScreen;
            view = Data.readFile();

            printer = new Printer();
            ascending = true;
            updateList(Data.readFile());
        }

        public Data View { get; set; }

        private void createB_Click(object sender, EventArgs e)
        {
            new CreateForm(this, Data.readFile()).ShowDialog();
        }

        private void viewB_Click(object sender, EventArgs e)
        {
            new ViewForm(this, listPs.SelectedItems[0].Text).ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm.Visible = true;
        }

        private void findB_Click(object sender, EventArgs e)
        {
            new FindForm(this, Data.readFile()).ShowDialog();
        }

        public void updateList()
        {
            listPs.Items.Clear();
            view = Data.readFile();

            for (int i = 0; i < view.Patients.Count; i++)
            {
                listPs.Items.Add(new ListViewItem(new string[] { view.Patients[i].PatientId, view.Patients[i].Fname , view.Patients[i].Lname, view.Patients[i].Gender, "" + view.Patients[i].Condition }));
            }
        }

        public void updateList(Data data)
        {
            foreach (Patient p in data.Patients) MessageBox.Show(p.PatientId);
            listPs.Items.Clear();
            view = data;
            for (int i = 0; i < view.Patients.Count; i++)
            {
                listPs.Items.Add(new ListViewItem(new string[] { view.Patients[i].PatientId, view.Patients[i].Fname, view.Patients[i].Lname, view.Patients[i].Gender, "" + view.Patients[i].Condition }));
            }
        }

        private void listPs_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            columnSort(e.Column);
        }

        private void columnSort(int colIdx)
        {
            List<Patient> newView = view.Patients;

            switch (colIdx)
            {
                case 0:
                    if (ascending)
                        newView = view.Patients.OrderByDescending(o => o.PatientId).ToList();
                    else
                        newView = view.Patients.OrderBy(o => o.PatientId).ToList();
                    break;
                case 1:
                    if (ascending)
                        newView = view.Patients.OrderByDescending(o => o.Fname).ToList();
                    else
                        newView = view.Patients.OrderBy(o => o.Fname).ToList();
                    break;
                case 2:
                    if (ascending)
                        newView = view.Patients.OrderByDescending(o => o.Lname).ToList();
                    else
                        newView = view.Patients.OrderBy(o => o.Lname).ToList();
                    break;
                case 3:
                    if (ascending)
                        newView = view.Patients.OrderByDescending(o => o.Gender).ToList();
                    else
                        newView = view.Patients.OrderBy(o => o.Gender).ToList();
                    break;
                case 4:
                    if (ascending)
                        newView = view.Patients.OrderByDescending(o => o.Condition).ToList();
                    else
                        newView = view.Patients.OrderBy(o => o.Condition).ToList();
                    break;
            }
            ascending = !ascending;
            updateList(new Data() { Patients = newView });
            return;
        }

        private void listPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPs.SelectedItems.Count == 0)
            {
                viewB.Enabled = false;
                removeB.Enabled = false;
                return;
            }
            viewB.Enabled = true;
            removeB.Enabled = true;
        }

        private void removeB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPs.SelectedItems.Count; i++)
                foreach (Patient p in Data.readFile().Patients)
                    if (p.PatientId.Equals(listPs.SelectedItems[i].Text))
                    {
                        Data.readFile().removePatient(p);
                        break;
                    }
            updateList();
        }

        private void mergeB_Click(object sender, EventArgs e)
        {
            new MergeForm(this, Data.readFile()).ShowDialog();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            listPs.SelectedIndexChanged -= listPs_SelectedIndexChanged;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            listPs.SelectedIndexChanged -= listPs_SelectedIndexChanged;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            
        }

        private void printB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to print the data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (result != DialogResult.Yes) return;

            if (listPs.SelectedItems.Count != 0) {
                List<Patient> ps = new List<Patient>();
                for (int i = 0; i < listPs.SelectedItems.Count; i++)
                    foreach (Patient p in Data.readFile().Patients)
                    {
                        if (p.PatientId.Equals(listPs.SelectedItems[i].Text)) {
                            ps.Add(p);
                            break;
                        }
                    }
                printer.print(ps);
            }
            else    
                printer.printBoard(view);

            MessageBox.Show("Printing has been successful", "Print Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
