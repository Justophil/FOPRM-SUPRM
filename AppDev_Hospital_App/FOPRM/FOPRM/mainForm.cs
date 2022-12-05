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
            StartForm = titleScreen;
            data = new Data();
            view = data;

            printer = new Printer();
            ascending = true;
            updateList();
        }

        public Data View { get; set; }

        private void createB_Click(object sender, EventArgs e)
        {
            new CreateForm(this, data).ShowDialog();
        }

        private void viewB_Click(object sender, EventArgs e)
        {
            new ViewForm(this, data, listPs.SelectedItems[0].Text).ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm.Visible = true;
        }

        private void findB_Click(object sender, EventArgs e)
        {
            new FindForm(this, data).ShowDialog();
        }

        public void updateList()
        {
            listPs.Items.Clear();
            view = data.readFile();
            foreach (Patient p in view.Patients)
            {
                listPs.Items.Add(new ListViewItem(new string[] { p.PatientId, p.Fname, p.Lname, p.Gender, "" + p.Condition }));
            }
        }

        public void updateList(Data data)
        {
            listPs.Items.Clear();
            view = data;
            foreach (Patient p in view.Patients)
            {
                listPs.Items.Add(new ListViewItem(new string[] { p.PatientId, p.Fname, p.Lname, p.Gender, "" + p.Condition }));
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
                foreach (Patient p in data.Patients)
                    if (p.PatientId.Equals(listPs.SelectedItems[i].Text))
                    {
                        data.removePatient(p);
                        break;
                    }
            updateList();
        }

        private void mergeB_Click(object sender, EventArgs e)
        {
            new MergeForm(this, data).ShowDialog();
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
            printer.printBoard(view);
        }
    }
}
