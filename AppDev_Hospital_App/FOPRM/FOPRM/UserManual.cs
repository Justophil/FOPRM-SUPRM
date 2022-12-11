using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOPRM
{
    public partial class UserManual : Form
    {
        private string[] ss = new string[] { "legends", "create", "find", "merge", "view", "update", "remove", "print", "printBoard","sort", "refresh" };
        private int curT;
        private int curImg;
        public UserManual()
        {
            InitializeComponent();
            curT = 0;
            curImg = 0;
        }

        private void UserManual_Load(object sender, EventArgs e)
        {
            updateText(0);
        }

        private void updateText(int ssIdx)
        {
            textLb.Text = ss[ssIdx].ToUpper().ElementAt(0) + ss[ssIdx].Substring(1);
            curImg = 0;
            updateImage();
        }

        private void updateImage()
        {
            img.Image = (Image)Properties.Resources.ResourceManager.GetObject(ss[curT] + curImg);
        }

        private void nextB1_Click(object sender, EventArgs e)
        {
            curT = ++curT % ss.Length;
            updateText(curT);
        }

        private void prevB1_Click(object sender, EventArgs e)
        {
            if (curT <= 0) 
                curT = ss.Length; 
            updateText(--curT);
        }

        private void prevB2_Click(object sender, EventArgs e)
        {
            if (Properties.Resources.ResourceManager.GetObject(ss[curT] + (curImg - 1)) == null) return;
            --curImg; updateImage();
            nextB2.Enabled = true;
        }

        private void nextB2_Click(object sender, EventArgs e)
        {
            if (Properties.Resources.ResourceManager.GetObject(ss[curT] + (curImg + 1)) == null) return ;
            ++curImg; updateImage();
            prevB2.Enabled = true;
        }

    }
}
