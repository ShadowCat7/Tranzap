using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tranzap
{
    public static class ControlMaker
    {
        public static Label labelMaker(int x, int y, string text)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(x, y);
            label.Name = "label";
            label.Size = new System.Drawing.Size(35, 13);
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }
    }
}
