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
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            StartForm start = new StartForm();
            start.ShowDialog();
            InitializeComponent();
        }
    }
}