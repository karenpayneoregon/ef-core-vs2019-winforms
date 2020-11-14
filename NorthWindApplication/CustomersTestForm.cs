using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
//using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using NorthEntityLibrary.Classes;
using NorthEntityLibrary.Models;
using NorthWindApplication.Properties;

namespace NorthWindApplication
{
    public partial class CustomersTestForm : Form
    {
        private List<CustomerItem> _customerItems;
        public CustomersTestForm()
        {
            InitializeComponent();

            ExportByCountryButton.Image = Resources.csv;
            
            
            ExportByCountryButton.Enabled = false;
            Shown += CustomersTestForm_Shown;
        }

        private async void CustomersTestForm_Shown(object sender, EventArgs e)
        {
            try
            {
                
                CountryComboBox.DataSource = await CountryOperations.CountriesWithSelectAsync();
                _customerItems = await CustomerOperations.GetCustomersAsync();

                ExportByCountryButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load data\n{ex.Message}");
            }

        }

        private void ExportByCountryButton_Click(object sender, EventArgs e)
        {
            var country = ((Countries) CountryComboBox.SelectedItem);

            if (country.CountryIdentifier == -1)
            {
                MessageBox.Show("Please select a country");
                return;
            }
            else
            {
                var excluded = CustomerOperations.ToFile(_customerItems, country.Name);
                MessageBox.Show(excluded.ToString());
            }
        }
    }
}
