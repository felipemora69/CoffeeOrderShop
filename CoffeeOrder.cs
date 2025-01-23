using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutShopLesson
{
    public partial class CoffeeOrder : UserControl
    {
        public CoffeeOrder()
        {
            InitializeComponent();
        }

        public string LabelName
        {
            get { return lbl_Name.Text; }
            set { lbl_Name.Text = value; }
        }


        public override string ToString()
        {
            string message = LabelName + Environment.NewLine;
            message += " Size: " + cb_Size.Text + Environment.NewLine;
            if (hasCream.Checked) message += " with Cream" + Environment.NewLine;
            else message += " No Cream" + Environment.NewLine;
            message += "-------------------------------" + Environment.NewLine;
            return message;
        }
    }
}
