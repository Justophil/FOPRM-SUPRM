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
        MainForm main;
        Data data;
        public ViewForm(MainForm main, Data data, string ID)
        {
            InitializeComponent();
            this.main = main;
            this.data = data;
        }

        public void display(string ID) 
        { 

        }
    }
}
