using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Econ;
using Rezervasyon_Sistemi.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            oldAdminFeeBox.Text = Admin.AdminFee.ToString();
            foreach (Company company in Data_Storage.companies)
            {
                companyView.Rows.Add(company.CompanyId.ToString(),company.username);
                string text = $"{company.CompanyId}:{company.username}";
                compDeleteComb.Items.Add(text);
            }
            
        }

        private void compCreateButton_Click(object sender, EventArgs e)
        {
            if(companyAddNameBox.Text.Length > 0 && companyPassNameBox.Text.Length > 0)
            {
                Company company = new Company(companyAddNameBox.Text.ToUpper(), companyPassNameBox.Text);
                Data_Storage.companies.Add(company);

                var vehic1 = new StaticFuelCosts(VehicleType.Bus, 10, company.username);
                var vehic2 = new StaticFuelCosts(VehicleType.Airplane, 30, company.username);
                var vehic3 = new StaticFuelCosts(VehicleType.Train, 5, company.username);

                Data_Storage.fuelCosts.Add(vehic1);
                Data_Storage.fuelCosts.Add(vehic2);
                Data_Storage.fuelCosts.Add(vehic3);

                var person1 = new StaticPersonalExpenses(companyName: company.username, personalPrice: 7000, vehicleType: VehicleType.Bus);
                var person2 = new StaticPersonalExpenses(companyName: company.username, personalPrice: 14000, vehicleType: VehicleType.Airplane);
                var person3 = new StaticPersonalExpenses(companyName: company.username, personalPrice: 3000, vehicleType: VehicleType.Train);

                Data_Storage.personalExpenses.Add(person1);
                Data_Storage.personalExpenses.Add(person2);
                Data_Storage.personalExpenses.Add(person3);

                new AdminForm().Show();
                this.Close();
            }
        }

        private void newAdminFeeButton_Click(object sender, EventArgs e)
        {
            Admin.AdminFee = (int)newAdminFeeUpDown.Value;
            new AdminForm().Show();
            this.Close();
        }

        private void compDeleteButton_Click(object sender, EventArgs e)
        {
            if(compDeleteComb.SelectedIndex != -1)
            {
                int _companyId = int.Parse(compDeleteComb.SelectedItem.ToString().Split(':')[0]);
                string _companyName = compDeleteComb.SelectedItem.ToString().Split(':')[1];

                //Silinecek rotadaki araçların rezervasyonları sil Rezarvasyon ücreti geri ödenmez !
                Data_Storage.openReservations.RemoveAll(res => res.transport.trip.CompanyId == _companyId);
                //Araçları da sil
                Data_Storage.openTransports.RemoveAll(transport => transport.trip.CompanyId == _companyId);
                //rotayı da sil
                Data_Storage.openTrips.RemoveAll(trip => trip.CompanyId == _companyId);
                //giderleri de sil
                Data_Storage.fuelCosts.RemoveAll(fc => fc.CompanyName == _companyName);
                Data_Storage.personalExpenses.RemoveAll(pe => pe.CompanyName == _companyName);

                Data_Storage.companies.RemoveAll(c => c.CompanyId == _companyId);

                new AdminForm().Show();
                this.Close();

            }
        }
    }
}
