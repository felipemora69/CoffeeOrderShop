using System;
using System.CodeDom;
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
    public partial class DonutOrder : UserControl
    {
        public DonutOrder()
        {
            InitializeComponent();
        }

        public string LabelName
        {
            get { return lbl_Name.Text; }
            set { lbl_Name.Text = value; }
        }

        private void DonutOrder_Load(object sender, EventArgs e)
        {
            numericValue.Value = 1;
        }

        private void numericValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if(numericUpDown.Value == 0) numericUpDown.Value = 1;
            else if (numericUpDown.Value == 3) numericUpDown.Value = 6;
            else if (numericUpDown.Value == 5) numericUpDown.Value = 2;
            else if (numericUpDown.Value == 7) numericUpDown.Value = 12;
            else if (numericUpDown.Value == 13) numericUpDown.Value = 12;
            else if (numericUpDown.Value == 11) numericUpDown.Value = 6;
        }

        public override string ToString()
        {
            string message = LabelName + Environment.NewLine;
            message += " Flavor: " + cb_Flavor.Text + Environment.NewLine;
            message += " Amount: " + numericValue.Value + Environment.NewLine;
            message += "-------------------------------" + Environment.NewLine;
            return message;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Panel parentPanel = this.Parent as Panel;
            parentPanel.Controls.Remove(this);
            Container parentContainer = parentPanel.Parent as Container;
            parentContainer.RemoveDonut();
        }
    }
}
