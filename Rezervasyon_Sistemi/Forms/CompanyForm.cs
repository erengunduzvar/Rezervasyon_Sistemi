using Rezervasyon_Sistemi.Identification;
using Rezervasyon_Sistemi.Models;
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
        public int companyId { get; set; }
        public List<Transport> myTransports { get => Data_Storage.openTransports.Where(t => t.trip.CompanyId == companyId).ToList(); }
        public List<Trip> myTrips { get => Data_Storage.openTrips.Where(t => t.CompanyId == companyId).ToList(); }
        public CompanyForm(int companyId)
        {
            InitializeComponent();
            foreach(Trip trip in myTrips)
            {
                string text = $"{trip.tripId}: {ServiceClass.cityShortcutToFullName(trip.Route.startPosition)} - {ServiceClass.cityShortcutToFullName(trip.Route.endPosition)} {trip.date.ToShortDateString()}";
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

            this.companyId = companyId;
        }

        private void addTransButton_Click(object sender, EventArgs e)
        {
            if(addTransTripCombo.SelectedIndex != -1)
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
                new CompanyForm(this.companyId).Show();
                this.Close();
            }
        }
    }
}
