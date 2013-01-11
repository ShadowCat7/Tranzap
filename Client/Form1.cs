using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tranzap
{
    public partial class Form1 : Form
    {
        List<string> fileList;

        public Form1()
        {
            InitializeComponent();

            fileList = FileManager.listFiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool noFiles = true;
            for (int i = 0; i < fileList.Count; i++)
            {
                Controls.Add(ControlMaker.labelMaker(50, 50 + 20 * i, fileList[i]));
                noFiles = false;
            }
            if (noFiles)
            { Controls.Add(ControlMaker.labelMaker(50, 50, "You have no files.")); }
        }
    }
}
