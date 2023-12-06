using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models;
using Rezervasyon_Sistemi.Models.Econ;
using Rezervasyon_Sistemi.Models.Infrastructure;
using Rezervasyon_Sistemi.Services;
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
    public partial class CompanyForm : Form
    {
        public Company myCompany { get; set; }
        public List<Transport> myTransports { get => Data_Storage.openTransports.Where(t => t.trip.CompanyId == myCompany.CompanyId).ToList(); }
        public List<Trip> myTrips { get => Data_Storage.openTrips.Where(t => t.CompanyId == myCompany.CompanyId).ToList(); }
        public CompanyForm(Company company)
        {
            this.myCompany = company;
            InitializeComponent();
            CompanyNameLabel.Text = $"{myCompany.username} Firması Yönetim Paneli";
            foreach (Trip trip in myTrips)
            {
                string text = $"{trip.tripId}: {ServiceClass.cityShortcutToFullName(trip.Route.startPosition)} - {ServiceClass.cityShortcutToFullName(trip.Route.endPosition)} {trip.date.ToShortDateString()} {trip.VehicleType}";
                addTransTripCombo.Items.Add(text);
                deleteTripCombo.Items.Add(text);
            }

            foreach (Transport transport in myTransports)
            {
                string text = $"{transport.transportId}:Nolu {transport.trip.VehicleType},{transport.route.startPosition}-{transport.route.endPosition},{transport.trip.date.ToShortDateString()}";
                deleteTransCombo.Items.Add(text);
            }

            foreach (Route route in Data_Storage.routes)
            {
                string text = $"{route.BigRouteId}:Nolu Rota, Mesafe {route.distance}km";
                addTripRouteCombo.Items.Add(text);
            }

            
        }

        private void addTransButton_Click(object sender, EventArgs e)
        {
            if (addTransTripCombo.SelectedIndex != -1)
            {
                try
                {
                    int tripId = int.Parse(addTransTripCombo.SelectedItem.ToString().Split(':')[0]);
                    int seatCount = (int)addTransSeatUpDown.Value;
                    Data_Storage.openTransports.Add(new Transport(tripId, seatCount));
                }
                catch (Exception)
                {

                    throw;
                }
                new CompanyForm(this.myCompany).Show();
                this.Close();
            }
        }

        private void deleteTransButton_Click(object sender, EventArgs e)
        {
            if (deleteTransCombo.SelectedIndex != -1)
            {
                int transportId = int.Parse(deleteTransCombo.SelectedItem.ToString().Split(':')[0]);


                try
                {
                    //Silinecek araçtaki rezervasyonları sil Rezarvasyon ücreti geri ödenmez !
                    Data_Storage.openReservations.RemoveAll(r => r.transportId == transportId);
                    //Aracı da sil
                    Data_Storage.openTransports.RemoveAll(t => t.transportId == transportId);
                }
                catch (Exception)
                {

                    throw;
                }
                new CompanyForm(myCompany).Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addTripRouteCombo.SelectedIndex != -1 && addTripDateCombo.SelectedIndex != -1)
            {
                DateTime date;
                switch (addTripDateCombo.SelectedIndex)
                {
                    case 0:
                        date = new DateTime(2023, 12, 4);
                        break;
                    case 1:
                        date = new DateTime(2023, 12, 5);
                        break;
                    case 2:
                        date = new DateTime(2023, 12, 6);
                        break;
                    case 3:
                        date = new DateTime(2023, 12, 7);
                        break;
                    case 4:
                        date = new DateTime(2023, 12, 8);
                        break;
                    case 5:
                        date = new DateTime(2023, 12, 9);
                        break;
                    default:
                        date = new DateTime(2023, 12, 10);
                        break;
                }

                int routeId = int.Parse(addTripRouteCombo.SelectedItem.ToString().Split(':')[0]);
                VehicleType vehicleType;
                switch (routeId)
                {
                    case 1:
                    case 2:
                        vehicleType = VehicleType.Train;
                        break;
                    case 3:
                    case 4:
                        vehicleType = VehicleType.Bus;
                        break;
                    case 5:
                    case 6:
                        vehicleType = VehicleType.Airplane;
                        break;
                    default:
                        throw new Exception("route Id");
                };

                Data_Storage.openTrips.Add(
                    new Trip(vehicleType, routeId, date, Expense.calculateTripCost(this.myCompany.username.ToUpper(),routeId), this.myCompany.CompanyId)
                    );

                new CompanyForm(myCompany).Show();
                this.Close();

            }
        }

        private void deleteTripButton_Click(object sender, EventArgs e)
        {
            if(deleteTripCombo.SelectedIndex != -1)
            {
                int tripId = int.Parse(deleteTripCombo.SelectedItem.ToString().Split(':')[0]);

                //Silinecek rotadaki araçların rezervasyonları sil Rezarvasyon ücreti geri ödenmez !
                Data_Storage.openReservations.RemoveAll(res => res.transport.tripId == tripId);
                //Araçları da sil
                Data_Storage.openTransports.RemoveAll(transport => transport.tripId == tripId);
                //rotayı da sil
                Data_Storage.openTrips.RemoveAll(trip => trip.tripId == tripId);

                new CompanyForm(myCompany).Show();
                this.Close();
            }
        }

        private void dailyRevButton_Click(object sender, EventArgs e)
        {
            if(dailyRevDateCombo.SelectedIndex != -1)
            {
                DateTime date;
                switch (dailyRevDateCombo.SelectedIndex)
                {
                    case 0:
                        date = new DateTime(2023, 12, 4);
                        break;
                    case 1:
                        date = new DateTime(2023, 12, 5);
                        break;
                    case 2:
                        date = new DateTime(2023, 12, 6);
                        break;
                    case 3:
                        date = new DateTime(2023, 12, 7);
                        break;
                    case 4:
                        date = new DateTime(2023, 12, 8);
                        break;
                    case 5:
                        date = new DateTime(2023, 12, 9);
                        break;
                    default:
                        date = new DateTime(2023, 12, 10);
                        break;
                }


                List<Trip> temp = Data_Storage.openTrips
                    .Where(trip => trip.date.CompareTo(date) == 0 && trip.CompanyId == this.myCompany.CompanyId).ToList();

                double revenue = Data_Storage.openTrips
                    .Where(trip => trip.date.CompareTo(date) == 0 && trip.CompanyId == this.myCompany.CompanyId)
                    .Sum(trip => trip.Revenue);
                double expense = Data_Storage.openTrips
                    .Where(trip => trip.date.CompareTo(date) == 0 && trip.CompanyId == this.myCompany.CompanyId)
                    .Sum(trip => trip.Price);

                double total = revenue - expense;
                total -= Admin.AdminFee;
                string totalString;

                if(total >= 0)
                {
                    totalString = total.ToString("C");
                    dailyRevTextBox.ForeColor = Color.Green;
                }
                    
                else
                {
                    totalString = "-" + total.ToString("C");
                    dailyRevTextBox.ForeColor = Color.Red;
                }
                    

                dailyRevTextBox.Text = $"Kar: {revenue.ToString("C")}\nZarar: {expense.ToString("C")}\nTotal Girdi: {totalString}";


            }
        }

        private void allRevButton_Click(object sender, EventArgs e)
        {
            List<Trip> temp = Data_Storage.openTrips
                    .Where(trip => trip.CompanyId == this.myCompany.CompanyId).ToList();

            double revenue = Data_Storage.openTrips
                .Where(trip => trip.CompanyId == this.myCompany.CompanyId)
                .Sum(trip => trip.Revenue);
            double expense = Data_Storage.openTrips
                .Where(trip => trip.CompanyId == this.myCompany.CompanyId)
                .Sum(trip => trip.Price);

            double total = revenue - expense;
            total = total -(Admin.AdminFee * 7);
            string totalString;

            if (total >= 0)
            {
                totalString = total.ToString("C");
                allRevTextBox.ForeColor = Color.Green;
            }

            else
            {
                totalString = "-" + total.ToString("C");
                allRevTextBox.ForeColor = Color.Red;
            }


            allRevTextBox.Text = $"Kar: {revenue.ToString("C")}\nZarar: {expense.ToString("C")}\nTotal Girdi: {totalString}";


        }
    }
}
