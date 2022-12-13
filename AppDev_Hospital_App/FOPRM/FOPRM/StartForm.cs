using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace FOPRM
{
    public partial class StartForm : System.Windows.Forms.Form
    {
        // bringing the main form object to be able to show it
        public StartForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        // start the main form hiding the current
        private void startButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new MainForm(this).Show();
        }
        // Exit App (For openning the app misclick)
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                fadeIn.Stop();
                startButton.Enabled = true;
                exitButton.Enabled = true;
            }
            Opacity += 0.2;
        }

    }
}
