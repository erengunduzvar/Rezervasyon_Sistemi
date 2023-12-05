using Rezervasyon_Sistemi.Identification;
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
    public partial class ChooseTrip : Form
    {
        List<Transport> TransportList;
        int passengerCount;
        string startPos;
        string endPos;
        DateTime date;
        public ChooseTrip(List<Transport> Transports,int passengerCount,string startPos,string endPos,DateTime date)
        {
            this.TransportList = Transports;
            this.passengerCount = passengerCount;
            this.startPos = startPos;
            this.endPos = endPos;
            this.date = date;
            InitializeComponent();
        }

        private void ChooseTrip_Load(object sender, EventArgs e)
        {
            foreach (var transp in TransportList)
            { //Kalan koltuk sayısının dinamizmini hesaplamak
                availableTripDataGrid.Rows.Add(transp.trip.Company.username,transp.transportId.ToString(), transp.trip.date.ToShortDateString(),transp.AnyTransportValid(startPos,endPos,date).Count, $"{Services.ServiceClass.cityShortcutToFullName(transp.route.startPosition)} - {Services.ServiceClass.cityShortcutToFullName(transp.route.endPosition)}",transp.trip.VehicleType.ToString(), "Satın Al");
            }
            availableTripDataGrid.Columns[6].DefaultCellStyle.BackColor = Color.Green;
        }

        private void availableTripDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int _tripId = int.Parse(availableTripDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                Transport transport = TransportList.FirstOrDefault(t => t.tripId == _tripId);
                new ReserveForm(transport,startPos,endPos,date,passengerCount).Show();
                this.Close();

            }
        }

        private void availableTripDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
