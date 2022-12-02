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
    public partial class StartForm : System.Windows.Forms.Form
    {
        // bringing the main form object to be able to show it
        MainForm mainForm;
        public StartForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
        // start the main form hiding the current
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mainForm.Show();
        }
        // Exit App (For openning the app misclick)
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
