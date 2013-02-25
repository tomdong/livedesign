using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LiveDesign.Utilities;

namespace LiveDesign
{
    public partial class MainForm : Form
    {
        private Color mCustomizeBlue = Color.FromArgb(255, 73, 177, 98);
        public MainForm()
        {
            InitializeComponent();
            this.treeView1.BackColor = mCustomizeBlue;
            this.treeView1.ExpandAll();
        }
    }
}
