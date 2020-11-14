using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NorthEntityLibrary.Classes;

namespace NorthWindApplication
{
    public partial class CustomersTestForm : Form
    {
        public CustomersTestForm()
        {
            InitializeComponent();
        }

        private async void GetCustomersButton_Click(object sender, EventArgs e)
        {
            var customerList = await CustomerOperations.GetCustomersAsync();
            Text = customerList.Count.ToString();
        }
    }
}
