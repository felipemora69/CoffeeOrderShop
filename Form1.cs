using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutShopLesson
{
    public partial class Form1 : Form
    {
        bool changedLanguage = false;
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");


        }

        private void btn_AddCoffee_Click(object sender, EventArgs e)
        {
            orderContainer.AddCoffee();
        }

        private void btn_AddDonut_Click(object sender, EventArgs e)
        {
            orderContainer.AddDonut();
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            orderContainer.ClearAll();
        }

        private void btn_ClearLast_Click(object sender, EventArgs e)
        {
            orderContainer.ClearLast();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            rtb_Receipt.Text = orderContainer.ToString();
        }

        private void UpdateUIText()
        {
            btn_AddCoffee.Text = Properties.Resources.AddCoffee;
            btn_AddDonut.Text = Properties.Resources.AddDonut;
            btn_CheckOut.Text = Properties.Resources.Checkout;
            btn_ClearAll.Text = Properties.Resources.ClearAll;
            btn_ClearLast.Text = Properties.Resources.ClearLast;
            btn_Language.Text = Properties.Resources.Language;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUIText();
        }

        private void btn_Language_Click(object sender, EventArgs e)
        {
            if (changedLanguage)
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
            }
            changedLanguage = !changedLanguage;
            UpdateUIText();
        }
    }
}
