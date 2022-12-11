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
            this.KeyDown += MainForm_KeyDown;
            this.KeyPreview = true;

            updateList(Data.readFile());
        }

        private void createB_Click(object sender, EventArgs e)
        {
            new CreateForm(this, Data.readFile()).Show();
        }

        private void viewB_Click(object sender, EventArgs e)
        {
            if (listPs.SelectedItems.Count != 0)
                new ViewForm(this, listPs.SelectedItems[0].Text).Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i != 0; i = Application.OpenForms.Count - 1)
            {
                Application.OpenForms[i].Close();
            }
            StartForm.Visible = true;
        }

        private void findB_Click(object sender, EventArgs e)
        {
            new FindForm(this, Data.readFile()).Show();
        }

        public void updateList()
        {
            listPs.Items.Clear();
            view = Data.readFile();

            for (int i = 0; i < view.Patients.Count; i++)
            {
                listPs.Items.Add(new ListViewItem(new string[] { view.Patients[i].PatientId, view.Patients[i].Fname, view.Patients[i].Lname, view.Patients[i].Gender, "" + view.Patients[i].Condition }));
            }
        }

        public void updateList(Data data)
        {
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
            view = Data.readFile();
            for (int i = 0; i < listPs.SelectedItems.Count; i++)
            {
                foreach (Patient p in view.Patients)
                {
                    if (p.PatientId.Equals(listPs.SelectedItems[i].Text))
                    {
                        view.Patients.Remove(p);
                        break;
                    }
                }
            }
            Data.writeFile(view);
            updateList(Data.readFile());
        }

        private void mergeB_Click(object sender, EventArgs e)
        {
            new MergeForm(this, Data.readFile()).Show();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            listPs.SelectedIndexChanged -= listPs_SelectedIndexChanged;
        }

        private void MainForm_Leave(object sender, EventArgs e)
        {
            listPs.SelectedIndexChanged -= listPs_SelectedIndexChanged;
        }

        private void printB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to print the data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.Yes) return;

            if (listPs.SelectedItems.Count != 0)
            {
                List<Patient> ps = new List<Patient>();
                for (int i = 0; i < listPs.SelectedItems.Count; i++)
                    foreach (Patient p in Data.readFile().Patients)
                    {
                        if (p.PatientId.Equals(listPs.SelectedItems[i].Text))
                        {
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

        private void listPs_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F5) updateList();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) updateList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            updateList();
        }

        private void helpB_Click(object sender, EventArgs e)
        {
            new UserManual().Show();
        }
    }
}
