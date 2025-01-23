using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutShopLesson
{
    public partial class Container : UserControl
    {
        private int coffeeCount;
        private int donutCount;
        private int yAxis;

        public Container()
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            panel.AutoScroll = true;
            coffeeCount = 0;
            donutCount = 0;
            yAxis = 3;

        }

        public void ClearAll()
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);

            }
            //panel.Controls.Clear(); alternative.
            yAxis = 3;
            coffeeCount = 0;
            donutCount = 0;

        }

        internal void ClearLast()
        {
            if (panel.Controls.Count > 0)
            {
                if (panel.Controls[panel.Controls.Count-1] is CoffeeOrder)
                {
                    coffeeCount--;
                }
                else
                {
                    donutCount--;
                }
                
                int tempY = panel.Controls[panel.Controls.Count - 1].Size.Height;
                panel.Controls.RemoveAt(panel.Controls.Count - 1);
                
                
                yAxis -= tempY + 3;
            }
            else
            {
                MessageBox.Show("There are no orders on the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AddCoffee()
        {
            coffeeCount++;
            CoffeeOrder coffee = new CoffeeOrder();
            coffee.LabelName = "Coffee Order #" + coffeeCount.ToString();
            coffee.Name = "CoffeeOrder"+coffeeCount.ToString();
            coffee.Location = new Point(10, yAxis - panel.VerticalScroll.Value);
            yAxis += coffee.Size.Height + 3;
            
            panel.Controls.Add(coffee);
            
        }

        public void AddDonut()
        {
            donutCount++;
            DonutOrder donut = new DonutOrder();
            donut.LabelName = "Donut Order #" + donutCount.ToString();
            donut.Name = "DonutOrder" + donutCount.ToString();
            donut.Location = new Point (10, yAxis - panel.VerticalScroll.Value);
            yAxis += donut.Size.Height + 3;

            panel.Controls.Add(donut);

        }

        public void RemoveDonut()
        {
            yAxis -= 123 + 3;
            donutCount--;
            ReOrder();
        }

        public void ReOrder()
        {
            yAxis = 3;
            donutCount = 0;
            foreach (UserControl userControl in panel.Controls)
            {
                if (userControl is DonutOrder)
                {
                    donutCount++;
                    ((DonutOrder)userControl).LabelName = "Donut Order #" + donutCount.ToString();
                    userControl.Name = "DonutOrder" + donutCount.ToString();
                }
                userControl.Location = new Point(10, yAxis - panel.VerticalScroll.Value);
                yAxis += userControl.Size.Height + 3;
            }
        }

        public override string ToString()
        {
            string message = string.Empty;
            foreach(UserControl userControl in panel.Controls)
            {
                message += userControl.ToString();
            }
            return message;
        }

    }
}
